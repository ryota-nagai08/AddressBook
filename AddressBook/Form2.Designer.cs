namespace AddressBook
{
    partial class frmAddressEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCotroll = new System.Windows.Forms.Panel();
            this.btnVariety = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblMark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblBirthday_day = new System.Windows.Forms.Label();
            this.txtBirthday_day = new System.Windows.Forms.TextBox();
            this.lblBirthday_month = new System.Windows.Forms.Label();
            this.txtBirthday_month = new System.Windows.Forms.TextBox();
            this.lblBirthday_year = new System.Windows.Forms.Label();
            this.txtBirthday_year = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMarkTel2_2 = new System.Windows.Forms.Label();
            this.lblMarkTel2_1 = new System.Windows.Forms.Label();
            this.txtTel2_3 = new System.Windows.Forms.TextBox();
            this.txtTel2_2 = new System.Windows.Forms.TextBox();
            this.txtTel2_1 = new System.Windows.Forms.TextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarkTel1_1 = new System.Windows.Forms.Label();
            this.txtTel1_3 = new System.Windows.Forms.TextBox();
            this.txtTel1_2 = new System.Windows.Forms.TextBox();
            this.txtTel1_1 = new System.Windows.Forms.TextBox();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblMarkTel1 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtKana = new System.Windows.Forms.TextBox();
            this.lblKana = new System.Windows.Forms.Label();
            this.lblMarkKana = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarkName = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlCotroll.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(778, 50);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(778, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "連絡先変更";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCotroll
            // 
            this.pnlCotroll.Controls.Add(this.btnVariety);
            this.pnlCotroll.Controls.Add(this.btnUpdate);
            this.pnlCotroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCotroll.Location = new System.Drawing.Point(0, 594);
            this.pnlCotroll.Name = "pnlCotroll";
            this.pnlCotroll.Size = new System.Drawing.Size(778, 50);
            this.pnlCotroll.TabIndex = 1;
            // 
            // btnVariety
            // 
            this.btnVariety.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnVariety.Location = new System.Drawing.Point(650, 10);
            this.btnVariety.Name = "btnVariety";
            this.btnVariety.Size = new System.Drawing.Size(125, 33);
            this.btnVariety.TabIndex = 1;
            this.btnVariety.Text = "データ削除";
            this.btnVariety.UseVisualStyleBackColor = true;
            this.btnVariety.Click += new System.EventHandler(this.btnVariety_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdate.Location = new System.Drawing.Point(520, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "変更登録";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.lblMark);
            this.pnlList.Controls.Add(this.txtRemark);
            this.pnlList.Controls.Add(this.lblRemark);
            this.pnlList.Controls.Add(this.lblBirthday_day);
            this.pnlList.Controls.Add(this.txtBirthday_day);
            this.pnlList.Controls.Add(this.lblBirthday_month);
            this.pnlList.Controls.Add(this.txtBirthday_month);
            this.pnlList.Controls.Add(this.lblBirthday_year);
            this.pnlList.Controls.Add(this.txtBirthday_year);
            this.pnlList.Controls.Add(this.lblBirthday);
            this.pnlList.Controls.Add(this.txtAddress);
            this.pnlList.Controls.Add(this.lblAddress);
            this.pnlList.Controls.Add(this.lblMarkTel2_2);
            this.pnlList.Controls.Add(this.lblMarkTel2_1);
            this.pnlList.Controls.Add(this.txtTel2_3);
            this.pnlList.Controls.Add(this.txtTel2_2);
            this.pnlList.Controls.Add(this.txtTel2_1);
            this.pnlList.Controls.Add(this.lblTel2);
            this.pnlList.Controls.Add(this.label3);
            this.pnlList.Controls.Add(this.lblMarkTel1_1);
            this.pnlList.Controls.Add(this.txtTel1_3);
            this.pnlList.Controls.Add(this.txtTel1_2);
            this.pnlList.Controls.Add(this.txtTel1_1);
            this.pnlList.Controls.Add(this.lblTel1);
            this.pnlList.Controls.Add(this.lblMarkTel1);
            this.pnlList.Controls.Add(this.txtCompany);
            this.pnlList.Controls.Add(this.lblCompany);
            this.pnlList.Controls.Add(this.txtKana);
            this.pnlList.Controls.Add(this.lblKana);
            this.pnlList.Controls.Add(this.lblMarkKana);
            this.pnlList.Controls.Add(this.txtName);
            this.pnlList.Controls.Add(this.label1);
            this.pnlList.Controls.Add(this.lblMarkName);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 50);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(10, 50, 10, 50);
            this.pnlList.Size = new System.Drawing.Size(778, 544);
            this.pnlList.TabIndex = 2;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMark.Location = new System.Drawing.Point(143, 418);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(70, 24);
            this.lblMark.TabIndex = 35;
            this.lblMark.Text = "*必須";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRemark.Location = new System.Drawing.Point(275, 348);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(300, 50);
            this.txtRemark.TabIndex = 34;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRemark.Location = new System.Drawing.Point(177, 351);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(58, 24);
            this.lblRemark.TabIndex = 33;
            this.lblRemark.Text = "備考";
            // 
            // lblBirthday_day
            // 
            this.lblBirthday_day.AutoSize = true;
            this.lblBirthday_day.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBirthday_day.Location = new System.Drawing.Point(510, 308);
            this.lblBirthday_day.Name = "lblBirthday_day";
            this.lblBirthday_day.Size = new System.Drawing.Size(34, 24);
            this.lblBirthday_day.TabIndex = 32;
            this.lblBirthday_day.Text = "日";
            // 
            // txtBirthday_day
            // 
            this.txtBirthday_day.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBirthday_day.Location = new System.Drawing.Point(450, 305);
            this.txtBirthday_day.Name = "txtBirthday_day";
            this.txtBirthday_day.Size = new System.Drawing.Size(50, 31);
            this.txtBirthday_day.TabIndex = 31;
            // 
            // lblBirthday_month
            // 
            this.lblBirthday_month.AutoSize = true;
            this.lblBirthday_month.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBirthday_month.Location = new System.Drawing.Point(410, 308);
            this.lblBirthday_month.Name = "lblBirthday_month";
            this.lblBirthday_month.Size = new System.Drawing.Size(34, 24);
            this.lblBirthday_month.TabIndex = 30;
            this.lblBirthday_month.Text = "月";
            // 
            // txtBirthday_month
            // 
            this.txtBirthday_month.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBirthday_month.Location = new System.Drawing.Point(361, 305);
            this.txtBirthday_month.Name = "txtBirthday_month";
            this.txtBirthday_month.Size = new System.Drawing.Size(50, 31);
            this.txtBirthday_month.TabIndex = 29;
            // 
            // lblBirthday_year
            // 
            this.lblBirthday_year.AutoSize = true;
            this.lblBirthday_year.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBirthday_year.Location = new System.Drawing.Point(331, 308);
            this.lblBirthday_year.Name = "lblBirthday_year";
            this.lblBirthday_year.Size = new System.Drawing.Size(34, 24);
            this.lblBirthday_year.TabIndex = 28;
            this.lblBirthday_year.Text = "年";
            // 
            // txtBirthday_year
            // 
            this.txtBirthday_year.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBirthday_year.Location = new System.Drawing.Point(275, 305);
            this.txtBirthday_year.Name = "txtBirthday_year";
            this.txtBirthday_year.Size = new System.Drawing.Size(50, 31);
            this.txtBirthday_year.TabIndex = 27;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBirthday.Location = new System.Drawing.Point(177, 308);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(106, 24);
            this.lblBirthday.TabIndex = 26;
            this.lblBirthday.Text = "生年月日";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAddress.Location = new System.Drawing.Point(275, 235);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 50);
            this.txtAddress.TabIndex = 25;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAddress.Location = new System.Drawing.Point(177, 238);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 24);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "住　所";
            // 
            // lblMarkTel2_2
            // 
            this.lblMarkTel2_2.AutoSize = true;
            this.lblMarkTel2_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMarkTel2_2.Location = new System.Drawing.Point(435, 195);
            this.lblMarkTel2_2.Name = "lblMarkTel2_2";
            this.lblMarkTel2_2.Size = new System.Drawing.Size(22, 24);
            this.lblMarkTel2_2.TabIndex = 22;
            this.lblMarkTel2_2.Text = "-";
            // 
            // lblMarkTel2_1
            // 
            this.lblMarkTel2_1.AutoSize = true;
            this.lblMarkTel2_1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMarkTel2_1.Location = new System.Drawing.Point(355, 195);
            this.lblMarkTel2_1.Name = "lblMarkTel2_1";
            this.lblMarkTel2_1.Size = new System.Drawing.Size(22, 24);
            this.lblMarkTel2_1.TabIndex = 21;
            this.lblMarkTel2_1.Text = "-";
            // 
            // txtTel2_3
            // 
            this.txtTel2_3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTel2_3.Location = new System.Drawing.Point(460, 192);
            this.txtTel2_3.Name = "txtTel2_3";
            this.txtTel2_3.Size = new System.Drawing.Size(50, 31);
            this.txtTel2_3.TabIndex = 20;
            // 
            // txtTel2_2
            // 
            this.txtTel2_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTel2_2.Location = new System.Drawing.Point(380, 192);
            this.txtTel2_2.Name = "txtTel2_2";
            this.txtTel2_2.Size = new System.Drawing.Size(50, 31);
            this.txtTel2_2.TabIndex = 19;
            // 
            // txtTel2_1
            // 
            this.txtTel2_1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTel2_1.Location = new System.Drawing.Point(300, 192);
            this.txtTel2_1.Name = "txtTel2_1";
            this.txtTel2_1.Size = new System.Drawing.Size(50, 31);
            this.txtTel2_1.TabIndex = 18;
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTel2.Location = new System.Drawing.Point(177, 195);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(122, 24);
            this.lblTel2.TabIndex = 17;
            this.lblTel2.Text = "電話番号２";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(435, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "-";
            // 
            // lblMarkTel1_1
            // 
            this.lblMarkTel1_1.AutoSize = true;
            this.lblMarkTel1_1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMarkTel1_1.Location = new System.Drawing.Point(355, 152);
            this.lblMarkTel1_1.Name = "lblMarkTel1_1";
            this.lblMarkTel1_1.Size = new System.Drawing.Size(22, 24);
            this.lblMarkTel1_1.TabIndex = 14;
            this.lblMarkTel1_1.Text = "-";
            this.lblMarkTel1_1.Click += new System.EventHandler(this.lblMarkTel1_1_Click);
            // 
            // txtTel1_3
            // 
            this.txtTel1_3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTel1_3.Location = new System.Drawing.Point(460, 149);
            this.txtTel1_3.Name = "txtTel1_3";
            this.txtTel1_3.Size = new System.Drawing.Size(50, 31);
            this.txtTel1_3.TabIndex = 12;
            // 
            // txtTel1_2
            // 
            this.txtTel1_2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTel1_2.Location = new System.Drawing.Point(380, 149);
            this.txtTel1_2.Name = "txtTel1_2";
            this.txtTel1_2.Size = new System.Drawing.Size(50, 31);
            this.txtTel1_2.TabIndex = 11;
            // 
            // txtTel1_1
            // 
            this.txtTel1_1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTel1_1.Location = new System.Drawing.Point(300, 149);
            this.txtTel1_1.Name = "txtTel1_1";
            this.txtTel1_1.Size = new System.Drawing.Size(50, 31);
            this.txtTel1_1.TabIndex = 10;
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTel1.Location = new System.Drawing.Point(177, 152);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(122, 24);
            this.lblTel1.TabIndex = 9;
            this.lblTel1.Text = "電話番号１";
            // 
            // lblMarkTel1
            // 
            this.lblMarkTel1.AutoSize = true;
            this.lblMarkTel1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMarkTel1.Location = new System.Drawing.Point(143, 152);
            this.lblMarkTel1.Name = "lblMarkTel1";
            this.lblMarkTel1.Size = new System.Drawing.Size(22, 24);
            this.lblMarkTel1.TabIndex = 8;
            this.lblMarkTel1.Text = "*";
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCompany.Location = new System.Drawing.Point(275, 106);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(300, 31);
            this.txtCompany.TabIndex = 7;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCompany.Location = new System.Drawing.Point(177, 109);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(82, 24);
            this.lblCompany.TabIndex = 6;
            this.lblCompany.Text = "会社名";
            // 
            // txtKana
            // 
            this.txtKana.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKana.Location = new System.Drawing.Point(275, 63);
            this.txtKana.Name = "txtKana";
            this.txtKana.Size = new System.Drawing.Size(300, 31);
            this.txtKana.TabIndex = 5;
            // 
            // lblKana
            // 
            this.lblKana.AutoSize = true;
            this.lblKana.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKana.Location = new System.Drawing.Point(177, 66);
            this.lblKana.Name = "lblKana";
            this.lblKana.Size = new System.Drawing.Size(62, 24);
            this.lblKana.TabIndex = 4;
            this.lblKana.Text = "カ　ナ";
            // 
            // lblMarkKana
            // 
            this.lblMarkKana.AutoSize = true;
            this.lblMarkKana.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMarkKana.Location = new System.Drawing.Point(143, 66);
            this.lblMarkKana.Name = "lblMarkKana";
            this.lblMarkKana.Size = new System.Drawing.Size(22, 24);
            this.lblMarkKana.TabIndex = 3;
            this.lblMarkKana.Text = "*";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(275, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 31);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(177, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "氏　名";
            // 
            // lblMarkName
            // 
            this.lblMarkName.AutoSize = true;
            this.lblMarkName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMarkName.Location = new System.Drawing.Point(143, 23);
            this.lblMarkName.Name = "lblMarkName";
            this.lblMarkName.Size = new System.Drawing.Size(22, 24);
            this.lblMarkName.TabIndex = 0;
            this.lblMarkName.Text = "*";
            // 
            // frmAddressEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlCotroll);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmAddressEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "連絡先入力、または連絡先変更";
            this.Load += new System.EventHandler(this.frmAddressEdit_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlCotroll.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCotroll;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btnVariety;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarkName;
        private System.Windows.Forms.TextBox txtKana;
        private System.Windows.Forms.Label lblKana;
        private System.Windows.Forms.Label lblMarkKana;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblMarkTel1;
        private System.Windows.Forms.Label lblMarkTel1_1;
        private System.Windows.Forms.TextBox txtTel1_3;
        private System.Windows.Forms.TextBox txtTel1_2;
        private System.Windows.Forms.TextBox txtTel1_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarkTel2_2;
        private System.Windows.Forms.Label lblMarkTel2_1;
        private System.Windows.Forms.TextBox txtTel2_3;
        private System.Windows.Forms.TextBox txtTel2_2;
        private System.Windows.Forms.TextBox txtTel2_1;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBirthday_year;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblBirthday_year;
        private System.Windows.Forms.TextBox txtBirthday_month;
        private System.Windows.Forms.Label lblBirthday_day;
        private System.Windows.Forms.TextBox txtBirthday_day;
        private System.Windows.Forms.Label lblBirthday_month;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
    }
}