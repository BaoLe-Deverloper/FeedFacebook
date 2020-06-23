using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ManagerFacebook.DAO.models;
using ManagerFacebook.DAO.services;

namespace ManagerFacebook
{
    public partial class frAddGroupAccounts : DevExpress.XtraEditors.XtraForm
    {
        private List<GroupAccountsModel> groups;

        private GroupAccountsService groupAccountsService;
        public GroupAccountsModel currentGroup = null;
        public frAddGroupAccounts(List<GroupAccountsModel> _groups)
        {
            InitializeComponent();
            groups = _groups;
            groupAccountsService = new GroupAccountsService();
            dtgGroup.Font = new Font(new FontFamily("Arial"), 10); 
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2&& e.RowIndex>-1)
            {
                if (XtraMessageBox.Show("Do you want delete Groups?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
                {
                    int ID =  Convert.ToInt32(dtgGroup.Rows[e.RowIndex].Cells[0].Value);
                    if (groupAccountsService.DeleteGroup(ID))
                    {
                        groups = groupAccountsService.GetGroups();
                        loadGroups();
                    };
                }
            }
        }

        void loadGroups()
        {
            dtgGroup.Rows.Clear();
            foreach (var item in groups)
            {
                int id = dtgGroup.Rows.Add();
                dtgGroup.Rows[id].HeaderCell.Value = (id + 1).ToString();
                dtgGroup.Rows[id].Cells[0].Value = item.ID;
                dtgGroup.Rows[id].Cells[1].Value = item.NameGroup;
            }
        }

        private void frAddGroupAccounts_Load(object sender, EventArgs e)
        {
            loadGroups();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGroups.Text))
            {
                if (groupAccountsService.GetGroupByName(txtGroups.Text).NameGroup != null)
                {
                    XtraMessageBox.Show("This Group already exists !", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (groupAccountsService.AddGroup(txtGroups.Text))
                {
                    groups = groupAccountsService.GetGroups();
                    loadGroups();
                }
            }
            
           
         
        }
    }
}