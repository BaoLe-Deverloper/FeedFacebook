using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using DevExpress.XtraWaitForm;
using ManagerFacebook.Core;
using ManagerFacebook.DAO.models;
using ManagerFacebook.DAO.services;
using ManagerFacebook.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DataGridViewRow = System.Windows.Forms.DataGridViewRow;

namespace ManagerFacebook
{
    public partial class frMain : DevExpress.XtraEditors.XtraForm
    {
        private DataViewer dataViewer;
        private ucTool UCTool;
        ProgressPanel pr = new ProgressPanel();
        private AccountService accountService;
        private GroupAccountsService groupAccountsService;
        private GroupAccountsModel CurrentGroupAccount ;
        private List<GroupAccountsModel> groupAccounts;
        public frMain()
        {
            InitializeComponent();

            dataViewer =  new DataViewer();
            UCTool = new ucTool();
            dataViewer.Dock = DockStyle.Fill;
            dataViewer.dataGridView.HeaderForeColor = Color.White;
            dataViewer.dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSerif, 10);
            dataViewer.dataGridView.Font = new Font(new FontFamily("Arial"), 8);
            dataViewer.addGroupAccountToolStripMenuItem.Click += addGroupsHandle;
            accountService = new AccountService();

            groupAccountsService = new GroupAccountsService();
        }

        void loadGroupGUI()
        {
            groupAccounts = groupAccountsService.GetGroups();
            
            dataViewer.addAccountsToGroupsToolStripMenuItem.DropDownItems.Clear();
            barListLoadAccount.Strings.Clear();
            foreach (var gr in groupAccounts)
            {
                dataViewer.addAccountsToGroupsToolStripMenuItem.DropDownItems.Add(gr.NameGroup, ManagerFacebook.Properties.Resources.grouprows_32x32, onClick: ItemAddGroup_Click);
            }

            barListLoadAccount.Strings.AddRange(groupAccounts.Select(q => q.NameGroup).ToArray());
        }

        private void addGroupsHandle(object sender, EventArgs e)
        {
             frAddGroupAccounts addGroup = new frAddGroupAccounts(groupAccounts);
            addGroup.ShowDialog();
            loadGroupGUI();
        }

        private void ChangeBodyControl(UserControl us)
        {
            bodyControl.Controls.Clear();
            bodyControl.Controls.Add(us);
        }

        private void Loading()
        {       
            var x = (bodyControl.Width - pr.Width) / 2;
            pr.Location = new Point(x,200);
            bodyControl.Controls.Clear();
            bodyControl.Controls.Add(pr);
        
        }
        private void frMain_Load(object sender, EventArgs e)
        {
            ChangeBodyControl(dataViewer);

            loadGroupGUI();
            //accountService.InsertAccountModel(new AccountModel(){UID="18891403421", NameAccount = "Vân Anh", AccessToken = "HBSDBHS",
            //    Groups = 10, BirthDay = "03/04/1998", Cookie = "SNJSF", PathProfile = "SKFSF", Sex = null, Status = "Checkpoit", Password = "ZBDHBSDF", Friends = 10,GroupID = 1});

        }

        private void ItemAddGroup_Click(object sender, EventArgs e)
        {
           var UserAgents = File.ReadAllLines(Application.StartupPath + "\\data\\User-Agents.txt");
           Random rd = new Random();
           var item =  (sender as ToolStripItem).Text;
            var idGr = groupAccountsService.GetGroupByName(item).ID;
            foreach (DataGridViewRow row in dataViewer.dataGridView.SelectedRows)
            {
                string UID = row.Cells[1].Value.ToString();
                if(string.IsNullOrEmpty(UID))
                    break;
                var account = accountService.isExistAccount(UID);
                if (account!=null&&account.UID != null)
                {
                    account.GroupID = idGr;
                    accountService.DeleteAccount(UID);
                    accountService.InsertAccountModel(account);
                }
                else
                {
                    string Password= "";
                    string Cookie ="";
                    string _2FA = "";
                    if (row.Cells[14].Value != null)
                         Password = row.Cells[14].Value.ToString();
                    if (row.Cells[6].Value != null)
                        _2FA = row.Cells[6].Value.ToString();
                    if (row.Cells[7].Value != null)
                        Cookie = row.Cells[7].Value.ToString();
                    accountService.InsertAccountModel(new AccountModel()
                    {
                        UID= UID,
                        Password = Password,
                        Cookie = Cookie,
                        _2FA = _2FA,
                        GroupID = idGr,
                        UserAgent = UserAgents[rd.Next(UserAgents.Length)]
                    });
                }
               
                dataViewer.dataGridView.Rows.Remove(row);
            }


        }
 
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loading();
        }

        private void addAcc_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            var type = (e.Item as BarListItem).Strings[(int)e.Index];
            try
            {
                DataObject dataObject = (DataObject)Clipboard.GetDataObject();
                string[] array = Regex.Split(dataObject.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                string[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    if(string.IsNullOrEmpty(text))
                        break;
                    if (!text.Replace("\t", "").Trim().Equals(""))
                    {
                        string[] account = text.Split('|');
                        if (account.Length >= 1)
                        {
                            try
                            {

                                int id = dataViewer.dataGridView.Rows.Add();
                                dataViewer.dataGridView.Rows[id].Cells[0].Value = (id + 1).ToString();
                                dataViewer.dataGridView.Rows[id].Cells[1].Value = account[0].Trim();
                                dataViewer.dataGridView.Rows[id].Cells[14].Value = account[1].Trim();
                                switch (type)
                                {
                                    case "UID|Password|Cookie|2FA":
                                        dataViewer.dataGridView.Rows[id].Cells[6].Value = account[3].Trim();
                                        dataViewer.dataGridView.Rows[id].Cells[7].Value = account[2].Trim();
                                        break;
                                    case "UID|Password|Cookie":
                                        dataViewer.dataGridView.Rows[id].Cells[7].Value = account[2].Trim();
                                        break;
                                    case "UID|Password|2FA":
                                        dataViewer.dataGridView.Rows[id].Cells[6].Value = account[2].Trim();
                                        break;
                                    case "UID|Password":
                                        break;
                                    default:
                                        return;
                                }

                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }
            catch
            {
            }

        } 

        private void addtxt_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            var type = (e.Item as BarListItem).Strings[(int)e.Index];

            XtraOpenFileDialog openFile = new XtraOpenFileDialog();
            openFile.Title = "File Text Type " + type;
            openFile.Filter = $"File Text|*.txt|All|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var file = openFile.FileName;

                var data = File.ReadAllLines(file);
                dataViewer.dataGridView.Rows.Clear();
                foreach (var item in data)
                {
                    var account = item.Split('|');
                    int id = dataViewer.dataGridView.Rows.Add();
                    dataViewer.dataGridView.Rows[id].Cells[0].Value = (id + 1).ToString();
                    dataViewer.dataGridView.Rows[id].Cells[1].Value = account[0].Trim();
                    dataViewer.dataGridView.Rows[id].Cells[14].Value = account[1].Trim();
                    switch (type)
                    {
                        case "UID|Password|Cookie|2FA":
                            dataViewer.dataGridView.Rows[id].Cells[6].Value = account[3].Trim();
                            dataViewer.dataGridView.Rows[id].Cells[7].Value = account[2].Trim();
                            break;
                        case "UID|Password|Cookie":
                            dataViewer.dataGridView.Rows[id].Cells[7].Value = account[2].Trim();
                            break;
                        case "UID|Password|2FA":
                            dataViewer.dataGridView.Rows[id].Cells[6].Value = account[2].Trim();
                            break;
                        case "UID|Password":
                            break;
                        default:
                            return;
                    }
                }

                lbGroupAccount.Text = "Proccess Add Account To System";

            }
            

        }

        private IWebDriver OpenChrome(string id, List<string> Args = null)
        {
            ChromeOptions chromeOptions = null;
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            chromeOptions = new ChromeOptions();
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string user = "support";
            string pass = "admin";
            string host = "123.21.89.79";

            //Set up the SSH connection
            //var _client = new SshClient(host, user, pass);

            //    _client.Connect();
            //    ForwardedPortDynamic port = new ForwardedPortDynamic("127.0.0.1", 1880);
            //    _client.AddForwardedPort(port);
            //    if (_client.IsConnected)
            //    {
            //        port.Start();
            //    }
            //Start the connection

            //client.RunCommand("etc/init.d/networking restart");



            //chromeOptions.AddExtension(outPutDirectory + @"\extensions\extension_0_2_6_0.crx");
            if(Args != null)
            chromeOptions.AddArguments(Args);
            chromeOptions.AddArguments(new string[]
            {                  
                                "--window-size=430,580",
                                //"--disable-notifications",
                                " --window-position=10,10",
                                "--no-sandbox",
                              
                                "--disable-gpu",
                                "--disable-dev-shm-usage",
                                "--disable-web-security",
                                "--disable-rtc-smoothness-algorithm",
                                "--disable-webrtc-encryption",
                               "--disable-client-side-phishing-detection",
                                "--disable-webrtc-hw-decoding",
                                "--disable-webrtc-hw-encoding",
                                "--disable-webrtc-multiple-routes",
                                "--disable-webrtc-hw-vp8-encoding",
                                "--enforce-webrtc-ip-permission-check",
                                "--force-webrtc-ip-handling-policy",
                                "--ignore-certificate-errors",
                                "--disable-infobars",
                                "--mute-audio",
                                "--disable-popup-blocking",
                                "--disable-blink-features=AutomationControlled",
                                "--disable-user-media-security",
                                "--use-fake-ui-for-media-stream",
                                "--use-fake-mjpeg-decode-accelerator",
                                "--use-fake-device-for-media-stream",
                                "--use-fake-codec-for-peer-connection",
                                // "--proxy-server=127.0.0.1:1980",
                                "--user-data-dir=profiles\\profile_"+ id,
                                "--user-agent=Mozilla/5.0 (iPhone; CPU iPhone OS 13_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/69.0.3497.71 Mobile/15E148 Safari/605.1",
                                "--app=https://m.facebook.com"

            });
          
            var driver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromSeconds(180.0));
            return driver;
          
         }



        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            frAddGroupAccounts addGroup = new frAddGroupAccounts(groupAccounts);
            addGroup.ShowDialog();
            loadGroupGUI();
        }

        void LoadAccounts(List<AccountModel> accounts)
        {
            dataViewer.dataGridView.Rows.Clear();
            foreach (var account in accounts)
            {
                int id = dataViewer.dataGridView.Rows.Add();
                dataViewer.dataGridView.Rows[id].Cells[0].Value = (id + 1).ToString();
                dataViewer.dataGridView.Rows[id].Cells[1].Value = account.UID;
                dataViewer.dataGridView.Rows[id].Cells[2].Value = account.NameAccount;
                dataViewer.dataGridView.Rows[id].Cells[3].Value = account.Sex == 0 ? "--" :
                    account.Sex == 1 ? "Male" : "Female";
                dataViewer.dataGridView.Rows[id].Cells[4].Value = account.BirthDay;
                dataViewer.dataGridView.Rows[id].Cells[5].Value = account.DateCreate;
                dataViewer.dataGridView.Rows[id].Cells[6].Value = account._2FA;
                dataViewer.dataGridView.Rows[id].Cells[7].Value = account.Cookie;
                dataViewer.dataGridView.Rows[id].Cells[8].Value = account.Friends;
                dataViewer.dataGridView.Rows[id].Cells[9].Value = account.Groups;
                dataViewer.dataGridView.Rows[id].Cells[10].Value = account.Status;
                dataViewer.dataGridView.Rows[id].Cells[12].Value = account.PathProfile;
                dataViewer.dataGridView.Rows[id].Cells[13].Value = account.AccessToken;
                dataViewer.dataGridView.Rows[id].Cells[14].Value = account.Password;
            }
           
        }
        private void barListLoadAccount_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            var type = (e.Item as BarListItem).Strings[(int)e.Index];
            lbGroupAccount.Text = "Current group accounts: " + type;
            CurrentGroupAccount = groupAccountsService.GetGroupByName(type);
            var ls = accountService.GetAccountByGroupID(CurrentGroupAccount.ID);
            LoadAccounts(ls);
        }


        private void btnProfileChrome_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach(DataGridViewRow row in dataViewer.dataGridView.SelectedRows)
            {
                string UID = row.Cells[1].Value.ToString();
                var driver = OpenChrome(UID);
                driver.Navigate().GoToUrl("https://m.facebook.com");
            }
           
        }

        private void btnProfileFire_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btngetUSERGr_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnGetUserPage_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnGetUserPost_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeBodyControl(UCTool);
        }

        private void btnGetUserFr_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnSetAccessToken_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dataViewer.dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataViewer.dataGridView.SelectedRows[0];
                string UID = row.Cells[1].Value.ToString();
                var driver = OpenChrome(UID);
                driver.Navigate().GoToUrl("https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed");
                string data = driver.PageSource;
                Regex regex = new Regex(@"""accessToken\\"":\\""(.*?)\\""", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline | RegexOptions.Singleline);
                MatchCollection matchCollection = regex.Matches(data);
                if (matchCollection.Count > 0 && matchCollection[0].Groups.Count > 1)
                {
                    Settings.Default.AccessToken = matchCollection[0].Groups[1].Value.ToString();
                    Settings.Default.Save();
                }
                else
                MessageBox.Show("Get Access Token Fail!");
            }
            else
            {
                MessageBox.Show("No Account Selected !");
            }
        }
    }
}
