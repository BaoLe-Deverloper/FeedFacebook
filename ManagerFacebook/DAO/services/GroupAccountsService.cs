using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Helpers;
using ManagerFacebook.DAO.models;
using ManagerFacebook.Properties;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.CompilerServices;

namespace ManagerFacebook.DAO.services
{
    public class GroupAccountsService
    {
        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        AccountService accountService = new AccountService();
        private string connectionString = $"Data Source={Application.StartupPath}/AppDataBase.sqlite;Version=3;New=False;Compress=True;";
        public GroupAccountsService()
        {
            sql_con = new SQLiteConnection(connectionString);
        }

        public void ExecuteQuery(string query)
        {
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = query;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        public  bool AddGroup(string NameGroup)
        {
            try
            {
                ExecuteQuery($"insert into GroupAccounts (NameGroup)  values('{NameGroup}')");

                return true;
            }
            catch
            {
                return false;
            }
         
        }

        public GroupAccountsModel GetGroupByName(string name)
        {
            sql_con.Open();
            sql_cmd = new SQLiteCommand($"SELECT * FROM GroupAccounts where NameGroup ='{name}'", sql_con);
            SQLiteDataReader sqliteDataReader = sql_cmd.ExecuteReader();
            GroupAccountsModel Groups = new GroupAccountsModel();
            while (sqliteDataReader.Read())
            {
                Groups.ID = Conversions.ToInteger(sqliteDataReader["ID"]);
                Groups.NameGroup = Conversions.ToString(sqliteDataReader["NameGroup"]);
            }
            sql_con.Close();
            return Groups;
        }
        public bool DeleteGroup(int ID)
        {
            try
            {
                var accounts = accountService.GetAccountByGroupID(ID);
                foreach (var acc in accounts)
                {
                    accountService.DeleteAccount(acc.UID);
                }
                ExecuteQuery($"delete from GroupAccounts where ID={ID}");
                return true;
            }
            catch
            {
                return false;
            }
           
        
        }
        public List<GroupAccountsModel> GetGroups()
        {
            sql_con.Open();
            sql_cmd = new SQLiteCommand($"SELECT * FROM GroupAccounts", sql_con);
            SQLiteDataReader sqliteDataReader = sql_cmd.ExecuteReader();
            List<GroupAccountsModel> Groups = new List<GroupAccountsModel>();
            while (sqliteDataReader.Read())
            {
                Groups.Add(new GroupAccountsModel()
                {
                    ID= Conversions.ToInteger(sqliteDataReader["ID"]),
                    NameGroup = Conversions.ToString(sqliteDataReader["NameGroup"])
                });
            }

            sql_cmd.Dispose();
            sql_con.Close();
            return Groups;

        }
    }
}
