using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerFacebook.DAO.models;
using ManagerFacebook.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ManagerFacebook.DAO.services
{
   public class AccountService
    {
        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        private string connectionString = $"Data Source={Application.StartupPath}/AppDataBase.sqlite;Version=3;New=False;Compress=True;";
        public AccountService()
        {
            sql_con = new SQLiteConnection(connectionString);
        }
      
        public  bool ExecuteQuery(string query)
        {
            sql_con.Open();

            try
            {
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = query;
                sql_cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sql_con.Close();
            }

        }

        //public static void CreatTable()
        //{
        //    ExecuteQuery("DROP TABLE IF EXISTS Accounts");
        //    ExecuteQuery(
        //        @"CREATE TABLE Accounts(DeviceID TEXT PRIMARY KEY,LDplayerName TEXT,UID TEXT,IDAccount TEXT,NameAccount TEXT,Password TEXT,_2FA TEXT,Groups TEXT,Proxy TEXT,Status TEXT,isOnline INTEGER)");
        //}

        public  bool InsertAccountModel(AccountModel acc)
        {
            try
            {
                ExecuteQuery(
                    $"insert into Accounts (UID,NameAccount,Sex,BirthDay,Friends,Groups,Password,_2FA,AccessToken,Cookie,PathProfile,Status,DateCreate,GroupID,UserAgent)" +
                    $"values('{acc.UID}','{acc.NameAccount}','{acc.Sex}','{acc.BirthDay}',{acc.Friends},{acc.Groups},'{acc.Password}','{acc._2FA}','{acc.AccessToken}'" +
                    $",'{acc.Cookie}','{acc.PathProfile}','{acc.Status}','{acc.DateCreate}',{acc.GroupID},'{acc.UserAgent}')");
                return true;
            }
            catch
            {
               return false;
            }
           
        }

        public AccountModel isExistAccount(string UID)
        {
            AccountModel AccountModel = new AccountModel();
            sql_con.Open();
            try
            {
                sql_cmd = new SQLiteCommand($"select * from Accounts where UID={UID}", sql_con);
                SQLiteDataReader rdr = sql_cmd.ExecuteReader();
              
                while (rdr.Read())
                {
                    AccountModel.UID = rdr["UID"].ToString();
                    AccountModel.NameAccount = rdr["NameAccount"] is DBNull ? null : rdr["NameAccount"].ToString();
                    AccountModel.Password = rdr["Password"] is DBNull ? null : rdr["Password"].ToString();
                    AccountModel._2FA = rdr["_2FA"] is DBNull ? null : rdr["_2FA"].ToString();
                    AccountModel.Groups = Conversions.ToInteger(rdr["Groups"]);
                    AccountModel.Friends = Conversions.ToInteger(rdr["Friends"]);
                    AccountModel.Status = rdr["Status"] is DBNull ? null : Conversions.ToString(rdr["Status"]);
                    AccountModel.Cookie = rdr["Cookie"] is DBNull ? null : Convert.ToString(rdr["Cookie"]);
                    AccountModel.AccessToken = rdr["AccessToken"] is DBNull ? null : Conversions.ToString(rdr["AccessToken"]);
                    AccountModel.BirthDay = rdr["BirthDay"] is DBNull ? null : Conversions.ToString(rdr["BirthDay"]);
                    AccountModel.GroupID = Conversions.ToInteger(rdr["GroupID"]);
                    AccountModel.DateCreate = rdr["DateCreate"] is DBNull ? null : Conversions.ToString(rdr["DateCreate"]);
                    AccountModel.PathProfile = rdr["PathProfile"] is DBNull ? null : Conversions.ToString(rdr["PathProfile"]);
                    AccountModel.Sex = Conversions.ToInteger(rdr["Sex"]);
                    AccountModel.UserAgent = rdr["UserAgent"] is DBNull ? null : Conversions.ToString(rdr["UserAgent"]);

                }
                return AccountModel;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                sql_con.Close();
            }
           
           
        }
        public  List<AccountModel> GetAccountByGroupID(int GroupID)
        {
            
            sql_con.Open();
            sql_cmd = new SQLiteCommand($"select * from Accounts where GroupID={GroupID}", sql_con);
            SQLiteDataReader rdr = sql_cmd.ExecuteReader();
            List<AccountModel> AccountModels = new List<AccountModel>();
            while (rdr.Read())
            {
             
                AccountModels.Add(new AccountModel()
                {
                    UID = rdr["UID"].ToString(),
                    NameAccount = rdr["NameAccount"] is DBNull ? null : rdr["NameAccount"].ToString(),
                    Password = rdr["Password"] is DBNull ? null : rdr["Password"].ToString(),
                    _2FA = rdr["_2FA"] is DBNull ? null: rdr["_2FA"].ToString(),
                    Groups = Conversions.ToInteger(rdr["Groups"]),
                    Friends = Conversions.ToInteger(rdr["Friends"]),
                    Status = rdr["Status"] is DBNull ? null : Conversions.ToString(rdr["Status"]),
                    Cookie = rdr["Cookie"] is DBNull ? null:Convert.ToString(rdr["Cookie"]),
                    AccessToken = rdr["AccessToken"]  is DBNull ? null :Conversions.ToString(rdr["AccessToken"]),
                    BirthDay = rdr["BirthDay"] is DBNull ? null : Conversions.ToString(rdr["BirthDay"]),
                    GroupID = Conversions.ToInteger(rdr["GroupID"]),
                    DateCreate = rdr["DateCreate"] is DBNull ? null : Conversions.ToString(rdr["DateCreate"]),
                    PathProfile = rdr["PathProfile"] is DBNull ? null:Conversions.ToString(rdr["PathProfile"]),
                    Sex = Conversions.ToInteger(rdr["Sex"]),
                    UserAgent = rdr["UserAgent"] is DBNull ? null : Conversions.ToString(rdr["UserAgent"])
                });
            }
             
            sql_con.Close();
            return AccountModels;
        }

        public void setGroupAccount(string UID, int IDGroup)
        {
          
            ExecuteQuery($"UPDATE Accounts SET [GroupID] = {IDGroup} WHERE UID='{UID}'");
        }

        public  bool DeleteAccount(string ID)
        {
           return ExecuteQuery($"delete from Accounts where UID='{ID}'");
        }


        //public  AccountModel GetAccountModel(string id)
        //{
        //    sql_con.Open();
        //    sql_cmd = new SQLiteCommand($"select * from Accounts where DeviceID='{id}'", sql_con);
        //    SQLiteDataReader rdr = sql_cmd.ExecuteReader();
        //    AccountModel AccountModel = new AccountModel();
        //    while (rdr.Read())
        //    {
        //        AccountModel.UID = rdr["UID"].ToString(); 
        //        AccountModel.NameAccount = rdr["NameAccount"].ToString();
        //        AccountModel.Password = rdr["Password"].ToString();
        //        AccountModel._2FA = rdr["_2FA"].ToString();
        //        AccountModel.Groups = rdr["Groups"].ToString();
        //        AccountModel.Status = rdr["Status"].ToString();
        //    }

        //    sql_con.Close();
        //    return AccountModel;
        //}

        public void UpdateAccount(AccountModel account)
        {
            ExecuteQuery($"UPDATE Accounts set NameAccount='{account.NameAccount}',Sex = '{account.Sex}',BirthDay = '{account.BirthDay}',Friends= {account.Friends}" +
                         $",Groups={account.Groups},Password='{account.Password}',_2FA='{account._2FA}',AccessToken='{account.AccessToken}'" +
                         $",Cookie='{account.Cookie}',PathProfile='{account.PathProfile}',Status='{account.Status}',DateCreate='{account.DateCreate}',UserAgent={account.UserAgent} where UID='{account.UID}'");
        }

        

        
    }
}
