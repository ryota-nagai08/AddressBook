using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AddressBook
{
    public partial class frmAddressList : Form
    {
        //データベース設定
        private readonly string connStr = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        public frmAddressList()
        {
            InitializeComponent();
            grdList.DataBindingComplete += GrdList_DataBindingComplete;
        }
        private void GrdList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //不要な列を非表示にする
            if (grdList.Columns.Contains("ID")) grdList.Columns["ID"].Visible = false;
            if (grdList.Columns.Contains("カナ")) grdList.Columns["カナ"].Visible = false;
            if (grdList.Columns.Contains("備考")) grdList.Columns["備考"].Visible = false;
            if (grdList.Columns.Contains("生年月日")) grdList.Columns["生年月日"].Visible=false;
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAddress_Load(object sender, EventArgs e)
        {
            grdList.AllowUserToAddRows = false;
            LoadAddressList();
        }

        private void LoadAddressList()
        {
            string sql = "SELECT " +
                "contsctid AS 'ID'," +
                "fullname AS '氏名'," +
                "furigana AS 'カナ'," +
                "companyname AS '会社名', " +
                "concat(tel1_1,'-',tel1_2,'-',tel1_3) AS '電話番号①'," +
                "concat(tel2_1,'-',tel2_2,'-',tel2_3) AS '電話番号②'," +
                "address AS '住所', " +
                "concat(birthday_year,'年',birthday_month,'月',birthday_day,'日') AS '生年月日', " +
                "remarks AS '備考' " +
                "FROM d_contactinformation;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    grdList.DataSource = table;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("データの取得に失敗しました。\n" + ex.Message);
            }
            grdList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT " +
                    "fullname AS '氏名', " +
                    "companyname AS '会社名', " +
                    "concat(tel1_1,'-',tel1_2,'-',tel1_3) AS '電話番号①', " +
                    "concat(tel2_1,'-',tel2_2,'-',tel2_3) AS '電話番号②', " +
                    "address AS '住所', " +
                    "concat(birthday_year,'年',birthday_month,'月',birthday_day,'日') AS '生年月日', " +
                    "remarks AS '備考' " +
                    "FROM d_contactinformation " +
                    "WHERE fullname LIKE @keyword " +
                    "OR companyname LIKE @keyword " +
                    "OR address LIKE @keyword " +
                    "OR remarks LIKE @keyword " +
                    "OR concat(tel1_1,'-',tel1_2,'-',tel1_3) LIKE @keyword " +
                    "OR concat(tel2_1,'-',tel2_2,'-',tel2_3) LIKE @keyword";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + txtKeyword.Text.Trim() + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        grdList.DataSource = table;
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("検索中にエラーが発生しました。\n" + ex.Message);
            }
            grdList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string contsctid = grdList.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string name = grdList.Rows[e.RowIndex].Cells["氏名"].Value.ToString();
            string furigana = grdList.Rows[e.RowIndex].Cells["カナ"].Value.ToString();
            string company = grdList.Rows[e.RowIndex].Cells["会社名"].Value.ToString();
            string phone1 = grdList.Rows[e.RowIndex].Cells["電話番号①"].Value.ToString();
            string phone2 = grdList.Rows[e.RowIndex].Cells["電話番号②"].Value.ToString();
            string address = grdList.Rows[e.RowIndex].Cells["住所"].Value.ToString();
            string birthday = grdList.Rows[e.RowIndex].Cells["生年月日"].Value.ToString();
            string remark = grdList.Rows[e.RowIndex].Cells["備考"].Value.ToString();

            //編集フォーム開く
            frmAddressEdit frmAddressEdit = new frmAddressEdit(contsctid,name,furigana,company,phone1,phone2,address,birthday,remark);

            //変更画面からokが帰ってきた場合、再読み込み
            if (frmAddressEdit.ShowDialog() == DialogResult.OK)
            {
                LoadAddressList();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddressEdit frmAddressEdit = new frmAddressEdit();

            if (frmAddressEdit.ShowDialog() == DialogResult.OK)
            {
                LoadAddressList();
            }
        }

        private void btnOutPutCSV_Click(object sender, EventArgs e)
        {
            string sql = "SELECT " +
                "contsctid AS 'ID', " +
                "fullname AS '氏名', " +
                "furigana AS 'カナ', " +
                "companyname AS '会社名', " +
                "concat(tel1_1,'-',tel1_2,'-',tel1_3) AS '電話番号①', " +
                "concat(tel2_1,'-',tel2_2,'-',tel2_3) AS '電話番号②', " +
                "address AS '住所', " +
                "concat(birthday_year,'年',birthday_month,'月',birthday_day,'日') AS '生年月日', " +
                "remarks AS '備考' " +
                "FROM d_contactinformation;";

            if (grdList.DataSource == null)
            {
                MessageBox.Show("出力するでーたがありません");
                return;
            }

            //保存フォルダ
            string folderPath = @"C:\temp\AddressBook\";

            //フォルダが存在しない場合
            if (!System.IO.File.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            //日付つきファイルの作成
            string fileName = $"address_list{DateTime.Now:yyyy-MM-dd_HH-mm}.csv";
            string filePath = System.IO.Path.Combine(folderPath, fileName);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    using (var sw = new System.IO.StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        //ヘッダー行
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            sw.Write(reader.GetName(i));
                            if (i < reader.FieldCount - 1) sw.Write(",");
                        }
                        sw.WriteLine();

                        //データ行
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string value = reader.IsDBNull(i) ? "" : reader.GetValue(i).ToString();

                                value = "\"" + value.Replace("\"", "\"\"") + "\"";
                                value = value.Replace("\r", "").Replace("\n", "");

                                sw.Write(value);
                                if (i < reader.FieldCount - 1) sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("CSV出力完了");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CSV出力中にエラー発生。\n" + ex.Message);
            }
        }
    }
}
