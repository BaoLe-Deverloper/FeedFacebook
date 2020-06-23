using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFacebook.DAO.models
{
    public class AccountModel
    {
        public string UID { get; set; }
        public string NameAccount { get; set; }
        public int Sex { get; set; }
        public string Password { get; set; }
        public string _2FA { get; set; }
        public string AccessToken { get; set; }
        public string Cookie { get; set; }
        public string PathProfile { get; set; }
        public string BirthDay { get; set; }
        public int Friends { get; set; }
        public int Groups { get; set; }
        public  string Status { get; set; }
        public string DateCreate { get; set; }
        public  int GroupID { get; set; }
        public string UserAgent { set; get; }
    }
}
