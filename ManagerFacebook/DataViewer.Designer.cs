namespace ManagerFacebook
{
    partial class DataViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewer));
            this.dataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addAccountsToGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._2FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friends = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.UID,
            this.NameAccount,
            this.sex,
            this.Birthday,
            this.dateCreated,
            this._2FA,
            this.cookie,
            this.Friends,
            this.Groups,
            this.Status,
            this.Action,
            this.PathProfile,
            this.AccessToken,
            this.password});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.DoubleBuffered = true;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1137, 556);
            this.dataGridView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountsToGroupsToolStripMenuItem,
            this.copyPasswordToolStripMenuItem,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 92);
            // 
            // addAccountsToGroupsToolStripMenuItem
            // 
            this.addAccountsToGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupAccountToolStripMenuItem});
            this.addAccountsToGroupsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAccountsToGroupsToolStripMenuItem.Image")));
            this.addAccountsToGroupsToolStripMenuItem.Name = "addAccountsToGroupsToolStripMenuItem";
            this.addAccountsToGroupsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addAccountsToGroupsToolStripMenuItem.Text = "Add Accounts To Groups";
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyPasswordToolStripMenuItem.Image")));
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy Password";
            this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 22);
            this.toolStripMenuItem2.Text = "Delete Account";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // addGroupAccountToolStripMenuItem
            // 
            this.addGroupAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addGroupAccountToolStripMenuItem.Image")));
            this.addGroupAccountToolStripMenuItem.Name = "addGroupAccountToolStripMenuItem";
            this.addGroupAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addGroupAccountToolStripMenuItem.Text = "Add Group Account";
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Num.Frozen = true;
            this.Num.HeaderText = "";
            this.Num.Name = "Num";
            this.Num.Width = 30;
            // 
            // UID
            // 
            this.UID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UID.Frozen = true;
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            // 
            // NameAccount
            // 
            this.NameAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameAccount.Frozen = true;
            this.NameAccount.HeaderText = "Name";
            this.NameAccount.Name = "NameAccount";
            this.NameAccount.Width = 130;
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sex.Frozen = true;
            this.sex.HeaderText = "Sex";
            this.sex.Name = "sex";
            this.sex.Width = 50;
            // 
            // Birthday
            // 
            this.Birthday.Frozen = true;
            this.Birthday.HeaderText = "Birth Day";
            this.Birthday.Name = "Birthday";
            // 
            // dateCreated
            // 
            this.dateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateCreated.HeaderText = "Date Created";
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Width = 120;
            // 
            // _2FA
            // 
            this._2FA.HeaderText = "2FA";
            this._2FA.Name = "_2FA";
            // 
            // cookie
            // 
            this.cookie.HeaderText = "Cookie";
            this.cookie.Name = "cookie";
            // 
            // Friends
            // 
            this.Friends.HeaderText = "Friends";
            this.Friends.Name = "Friends";
            // 
            // Groups
            // 
            this.Groups.HeaderText = "Groups";
            this.Groups.Name = "Groups";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // PathProfile
            // 
            this.PathProfile.HeaderText = "Path Profile";
            this.PathProfile.Name = "PathProfile";
            this.PathProfile.Visible = false;
            // 
            // AccessToken
            // 
            this.AccessToken.HeaderText = "Access Token";
            this.AccessToken.Name = "AccessToken";
            this.AccessToken.Visible = false;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.DoubleBuffered = true;
            this.Name = "DataViewer";
            this.Size = new System.Drawing.Size(1137, 556);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem addAccountsToGroupsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addGroupAccountToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn _2FA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friends;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}
