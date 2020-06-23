namespace ManagerFacebook
{
    partial class frAddGroupAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddGroupAccounts));
            this.dtgGroup = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtGroups = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new XanderUI.XUIButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroupAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroups.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGroup
            // 
            this.dtgGroup.AllowUserToAddRows = false;
            this.dtgGroup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgGroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGroup.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgGroup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameGroupAccount,
            this.Delete});
            this.dtgGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgGroup.DoubleBuffered = true;
            this.dtgGroup.EnableHeadersVisualStyles = false;
            this.dtgGroup.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgGroup.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgGroup.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dtgGroup.Location = new System.Drawing.Point(0, 0);
            this.dtgGroup.Name = "dtgGroup";
            this.dtgGroup.ReadOnly = true;
            this.dtgGroup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgGroup.RowHeadersWidth = 40;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgGroup.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgGroup.Size = new System.Drawing.Size(542, 195);
            this.dtgGroup.TabIndex = 0;
            this.dtgGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // txtGroups
            // 
            this.txtGroups.Location = new System.Drawing.Point(31, 242);
            this.txtGroups.Name = "txtGroups";
            this.txtGroups.Size = new System.Drawing.Size(344, 20);
            this.txtGroups.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " Name Group Accounts";
            // 
            // btnadd
            // 
            this.btnadd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.ButtonImage = null;
            this.btnadd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnadd.ButtonText = "Add Group Accounts";
            this.btnadd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnadd.ClickTextColor = System.Drawing.Color.MidnightBlue;
            this.btnadd.CornerRadius = 5;
            this.btnadd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnadd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnadd.HoverTextColor = System.Drawing.Color.Black;
            this.btnadd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnadd.Location = new System.Drawing.Point(401, 225);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 37);
            this.btnadd.TabIndex = 3;
            this.btnadd.TextColor = System.Drawing.Color.Black;
            this.btnadd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Visible = false;
            // 
            // NameGroupAccount
            // 
            this.NameGroupAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameGroupAccount.HeaderText = "Name Group Account";
            this.NameGroupAccount.Name = "NameGroupAccount";
            this.NameGroupAccount.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 32;
            // 
            // frAddGroupAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 285);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGroups);
            this.Controls.Add(this.dtgGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frAddGroupAccounts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Groups Accounts";
            this.Load += new System.EventHandler(this.frAddGroupAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroups.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgGroup;
        private DevExpress.XtraEditors.TextEdit txtGroups;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroupAccount;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}