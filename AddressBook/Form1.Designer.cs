namespace AddressBook
{
    partial class frmAddressList
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddressList));
            this.pnl1Title = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnOutPutCSV = new System.Windows.Forms.Button();
            this.pnl1Title.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1Title
            // 
            this.pnl1Title.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.pnl1Title, "pnl1Title");
            this.pnl1Title.Name = "pnl1Title";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtKeyword);
            this.pnlSearch.Controls.Add(this.lblKeyword);
            resources.ApplyResources(this.pnlSearch, "pnlSearch");
            this.pnlSearch.Name = "pnlSearch";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            resources.ApplyResources(this.txtKeyword, "txtKeyword");
            this.txtKeyword.Name = "txtKeyword";
            // 
            // lblKeyword
            // 
            resources.ApplyResources(this.lblKeyword, "lblKeyword");
            this.lblKeyword.Name = "lblKeyword";
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnOutPutCSV);
            this.pnlControl.Controls.Add(this.btnEdit);
            resources.ApplyResources(this.pnlControl, "pnlControl");
            this.pnlControl.Name = "pnlControl";
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.grdList);
            resources.ApplyResources(this.pnlList, "pnlList");
            this.pnlList.Name = "pnlList";
            // 
            // grdList
            // 
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.grdList, "grdList");
            this.grdList.Name = "grdList";
            this.grdList.RowHeadersVisible = false;
            this.grdList.RowTemplate.Height = 27;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellContentClick);
            this.grdList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellDoubleClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnOutPutCSV
            // 
            resources.ApplyResources(this.btnOutPutCSV, "btnOutPutCSV");
            this.btnOutPutCSV.Name = "btnOutPutCSV";
            this.btnOutPutCSV.UseVisualStyleBackColor = true;
            this.btnOutPutCSV.Click += new System.EventHandler(this.btnOutPutCSV_Click);
            // 
            // frmAddressList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnl1Title);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "frmAddressList";
            this.Load += new System.EventHandler(this.FormAddress_Load);
            this.pnl1Title.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1Title;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView grdList;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnOutPutCSV;
    }
}

