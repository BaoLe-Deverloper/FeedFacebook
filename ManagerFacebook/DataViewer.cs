using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using ManagerFacebook.DAO.services;

namespace ManagerFacebook
{
    public partial class DataViewer : UserControl
    {
        private AccountService accountService = new AccountService();
        public DataViewer()
        {
            InitializeComponent();
        }

        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string password = "";
            foreach (DataGridViewRow pass in dataGridView.SelectedRows)
            {
                password += pass.Cells["password"].Value +"\n";
            }
            Clipboard.SetText(password);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow acc in dataGridView.SelectedRows)
            {
                if (acc.Cells[1].Value != null)
                {
                    if (accountService.DeleteAccount(acc.Cells[1].Value.ToString()))
                    {
                        dataGridView.Rows.Remove(acc);
                    };
                }
            }
        }
    }
}
