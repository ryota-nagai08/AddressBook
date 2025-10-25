using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AddressBook
{
    public partial class frmAddressEdit : Form
    {
        private string _contsctid;
        private string _name;
        private string _furigana;
        private string _company;
        private string _phone1;
        private string _phone2;
        private string _address;
        private string _birthday;
        private string _remark;

        private bool _isEditMode;

        private readonly string connStr = "server=localhost;port=3306;" +
        "database=dbaddress;" +
        "user=root;" +
        "password=MySQL0826//;";

        //編集用
        public frmAddressEdit(string contsctid,string name,string furigana,string company,string phone1,string phone2,string address,string birthday,string remark)
        {
            InitializeComponent();

            _contsctid = contsctid;
            _name = name;
            _furigana = furigana;
            _company = company;
            _phone1 = phone1;
            _phone2 = phone2;
            _address = address;
            _birthday = birthday;
            _remark = remark;

            _isEditMode = true;
        }
        //新規登録用
        public frmAddressEdit()
        {
            InitializeComponent();
            _isEditMode = false;
        }
        private void lblMarkTel1_1_Click(object sender, EventArgs e)
        {

        }

        //ロード時の表示
        private void frmAddressEdit_Load(object sender, EventArgs e)
        {
            if (_isEditMode == true)
            {
                this.Text = "連絡先変更";
                btnUpdate.Text = "変更登録";
                txtName.Text = _name;
                txtKana.Text = _furigana;
                txtCompany.Text = _company;

                if (!string.IsNullOrEmpty(_phone1))
                {
                    string[] telParts1 = _phone1.Split('-');
                    {
                        if (telParts1.Length > 0) txtTel1_1.Text = telParts1[0];
                        if (telParts1.Length > 1) txtTel1_2.Text = telParts1[1];
                        if (telParts1.Length > 2) txtTel1_3.Text = telParts1[2];
                    }
                }

                if (!string.IsNullOrEmpty(_phone2))
                {
                    string[] telParts2 = _phone2.Split('-');
                    {
                        if (telParts2.Length > 0) txtTel2_1.Text = telParts2[0];
                        if (telParts2.Length > 1) txtTel2_2.Text = telParts2[1];
                        if (telParts2.Length > 2) txtTel2_3.Text = telParts2[2];
                    }
                }

                txtAddress.Text = _address;

                if (!string.IsNullOrEmpty(_birthday))
                {
                    string temp = _birthday.Replace("年", "-").Replace("月", "-").Replace("日", "");
                    string[] parts = temp.Split('-');

                    if (parts.Length >= 3)
                    {
                        txtBirthday_year.Text = parts[0];
                        txtBirthday_month.Text = parts[1];
                        txtBirthday_day.Text = parts[2];
                    }
                }
                txtRemark.Text = _remark;
            }
            else
            {
                this.Text = "連絡先入力";
                lblTitle.Text = "連絡先入力";
                btnUpdate.Text = "登録";

                btnVariety.Visible = false;
            }
            
        }

        //変更ボタンクリック時
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string furigana = txtKana.Text.Trim();
            string company = txtCompany.Text.Trim();
            string tel1_1 = txtTel1_1.Text.Trim();
            string tel1_2 = txtTel1_2.Text.Trim();
            string tel1_3 = txtTel1_3.Text.Trim();
            string tel2_1 = txtTel2_1.Text.Trim();
            string tel2_2 = txtTel2_2.Text.Trim();
            string tel2_3 = txtTel2_3.Text.Trim();
            string address = txtAddress.Text.Trim();
            string birthdayYear = txtBirthday_year.Text.Trim();
            string birthdayMonth = txtBirthday_month.Text.Trim();
            string birthdayDay = txtBirthday_day.Text.Trim();
            string remarks = txtRemark.Text.Trim();

            string sql = _isEditMode
                ? "UPDATE d_contactinformation SET " +
                "fullname=@fullname, furigana=@furigana, companyname=@companyname, tel1_1=@tel1_1, tel1_2=@tel1_2, tel1_3=@tel1_3, tel2_1=@tel2_1, tel2_2=@tel2_2, tel2_3=@tel2_3, address=@address, birthday_year=@birthday_year, birthday_month=@birthday_month, birthday_day=@birthday_day, remarks=@remark WHERE contsctid=@contsctid"
                : "INSERT INTO d_contactinformation(contsctid,fullname, furigana, companyname, tel1_1, tel1_2, tel1_3, tel2_1, tel2_2, tel2_3, address, birthday_year, birthday_month, birthday_day, remarks)" +
                " VALUES (@contsctid,@fullname, @furigana, @companyname, @tel1_1, @tel1_2, @tel1_3, @tel2_1, @tel2_2, @tel2_3, @address, @birthday_year, @birthday_month, @birthday_day, @remark)";


            //入力チェック
            if (string.IsNullOrEmpty(name)) 
            {
                MessageBox.Show("氏名を入力してください");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(furigana))
            {
                MessageBox.Show("フリガナを入力してください");
                txtKana.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tel1_1) || string.IsNullOrEmpty(tel1_2) || string.IsNullOrEmpty(tel1_3))
            {
                MessageBox.Show("電話番号①を入力してください");
                txtTel1_1.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr)) 
                {
                    conn.Open();

                    if(_isEditMode == false)
                    {
                        string maxId = "SELECT contsctid FROM d_contactinformation ORDER BY contsctid DESC LIMIT 1";
                        using (MySqlCommand cmdMax = new MySqlCommand(maxId, conn))
                        {
                            object result = cmdMax.ExecuteScalar();
                            if (result != null)
                            {
                                string lastId = result.ToString();
                                int num = int.Parse(lastId.Substring(0, 5)) + 1;
                                _contsctid = num.ToString("00000") + "NZC";
                            }
                            else
                            {
                                _contsctid = "01001NZC";
                            }
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn)) 
                    {
                        int yearValue, monthValue, dayValue;

                        cmd.Parameters.AddWithValue("@fullname", name);
                        cmd.Parameters.AddWithValue("@furigana", furigana);
                        cmd.Parameters.AddWithValue("@companyname", company);
                        cmd.Parameters.AddWithValue("@tel1_1", tel1_1);
                        cmd.Parameters.AddWithValue("@tel1_2", tel1_2);
                        cmd.Parameters.AddWithValue("@tel1_3", tel1_3);
                        cmd.Parameters.AddWithValue("@tel2_1", tel2_1);
                        cmd.Parameters.AddWithValue("@tel2_2", tel2_2);
                        cmd.Parameters.AddWithValue("@tel2_3", tel2_3);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@birthday_year", int.TryParse(birthdayYear, out yearValue) ? (object)yearValue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@birthday_month", int.TryParse(birthdayMonth, out monthValue) ? (object)monthValue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@birthday_day", int.TryParse(birthdayDay, out dayValue) ? (object)dayValue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@remark", remarks);
                        cmd.Parameters.AddWithValue("@contsctid", _contsctid);

                        int rows = cmd.ExecuteNonQuery();
                        if(rows > 0)
                        {
                            MessageBox.Show(_isEditMode ? "更新完了" : "登録完了");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("処理が実行されませんでした");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新中にエラー発生。\n" + ex.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVariety_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "本当に削除しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if( result == DialogResult.Yes )
            {
                try
                {
                    string deleteSql = "DELETE FROM d_contactinformation WHERE contsctid=@contsctid";
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@contsctid", _contsctid);
                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("削除完了");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("削除対象が見つかりません");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("削除中にエラー発生。\n" + ex.Message);
                }
            }
        }
    }
}
