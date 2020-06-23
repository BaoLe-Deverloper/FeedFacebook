namespace ManagerFacebook
{
    partial class ucTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTool));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.dataGridViewUIDPost = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyUIDUserNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewFriend = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDUser = new DevExpress.XtraEditors.TextEdit();
            this.indexx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExportUID = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUIDPost)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.txtExportUID);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIDUser);
            this.panel1.Controls.Add(this.dataGridViewFriend);
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewUIDPost);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 556);
            this.panel1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(63, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(460, 20);
            this.txtID.TabIndex = 0;
            // 
            // dataGridViewUIDPost
            // 
            this.dataGridViewUIDPost.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUIDPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUIDPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.UID,
            this.UserName});
            this.dataGridViewUIDPost.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewUIDPost.Location = new System.Drawing.Point(63, 90);
            this.dataGridViewUIDPost.Name = "dataGridViewUIDPost";
            this.dataGridViewUIDPost.RowHeadersVisible = false;
            this.dataGridViewUIDPost.Size = new System.Drawing.Size(460, 379);
            this.dataGridViewUIDPost.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Post ID";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(448, 61);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stt.HeaderText = "";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // UID
            // 
            this.UID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.Width = 180;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyUIDToolStripMenuItem,
            this.copyUIDUserNameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 48);
            // 
            // copyUIDToolStripMenuItem
            // 
            this.copyUIDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyUIDToolStripMenuItem.Image")));
            this.copyUIDToolStripMenuItem.Name = "copyUIDToolStripMenuItem";
            this.copyUIDToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.copyUIDToolStripMenuItem.Text = "Copy UID";
            this.copyUIDToolStripMenuItem.Click += new System.EventHandler(this.copyUIDToolStripMenuItem_Click);
            // 
            // copyUIDUserNameToolStripMenuItem
            // 
            this.copyUIDUserNameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyUIDUserNameToolStripMenuItem.Image")));
            this.copyUIDUserNameToolStripMenuItem.Name = "copyUIDUserNameToolStripMenuItem";
            this.copyUIDUserNameToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.copyUIDUserNameToolStripMenuItem.Text = "Copy UID|UserName";
            this.copyUIDUserNameToolStripMenuItem.Click += new System.EventHandler(this.copyUIDUserNameToolStripMenuItem_Click);
            // 
            // dataGridViewFriend
            // 
            this.dataGridViewFriend.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexx,
            this.id,
            this.nameUs});
            this.dataGridViewFriend.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewFriend.Location = new System.Drawing.Point(637, 90);
            this.dataGridViewFriend.Name = "dataGridViewFriend";
            this.dataGridViewFriend.RowHeadersVisible = false;
            this.dataGridViewFriend.Size = new System.Drawing.Size(465, 379);
            this.dataGridViewFriend.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1017, 61);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Scan";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User ID:";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Location = new System.Drawing.Point(637, 34);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(446, 20);
            this.txtIDUser.TabIndex = 6;
            // 
            // indexx
            // 
            this.indexx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.indexx.HeaderText = "";
            this.indexx.Name = "indexx";
            this.indexx.Width = 40;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "UID";
            this.id.Name = "id";
            this.id.Width = 160;
            // 
            // nameUs
            // 
            this.nameUs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameUs.HeaderText = "Name User";
            this.nameUs.Name = "nameUs";
            // 
            // txtExportUID
            // 
            this.txtExportUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportUID.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtExportUID.Appearance.Options.UseForeColor = true;
            this.txtExportUID.Location = new System.Drawing.Point(1027, 5);
            this.txtExportUID.Name = "txtExportUID";
            this.txtExportUID.Size = new System.Drawing.Size(75, 23);
            this.txtExportUID.TabIndex = 9;
            this.txtExportUID.Text = "Export TXT";
            // 
            // ucTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucTool";
            this.Size = new System.Drawing.Size(1137, 556);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUIDPost)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.DataGridView dataGridViewUIDPost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyUIDUserNameToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtIDUser;
        private System.Windows.Forms.DataGridView dataGridViewFriend;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexx;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUs;
        private DevExpress.XtraEditors.SimpleButton txtExportUID;
    }
}
