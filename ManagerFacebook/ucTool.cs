using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerFacebook.Core;
using ManagerFacebook.Properties;

namespace ManagerFacebook
{
    public partial class ucTool : UserControl
    {
        public ucTool()
        {
            InitializeComponent();
        }

        private void copyUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyUIDUserNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AccessToken != "")
            {
                var ListUser = FacebookHelpers.GET_UserByPost(txtID.Text, Settings.Default.AccessToken);

                foreach (var item in ListUser)
                {
                    int id = dataGridViewUIDPost.Rows.Add();
                    dataGridViewUIDPost.Rows[id].Cells[0].Value = (id + 1).ToString();
                    dataGridViewUIDPost.Rows[id].Cells[1].Value = item.Split('|')[0];
                    dataGridViewUIDPost.Rows[id].Cells[2].Value = item.Split('|')[1];
                }
            }
            else
            {
                MessageBox.Show("No Access Token !");
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

            if (Settings.Default.AccessToken != "")
            {
                var ListUser = FacebookHelpers.GET_ListFriends(txtIDUser.Text, Settings.Default.AccessToken);

                foreach (var item in ListUser)
                {
                    int id = dataGridViewFriend.Rows.Add();
                    dataGridViewFriend.Rows[id].Cells[0].Value = (id + 1).ToString();
                    dataGridViewFriend.Rows[id].Cells[1].Value = item.Split('|')[0];
                    dataGridViewFriend.Rows[id].Cells[2].Value = item.Split('|')[1];
                }
            }
            else
            {
                MessageBox.Show("No Access Token !");
            }
        }
    }
}
