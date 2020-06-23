using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFacebook.DAO.models
{
    public class SettingModel
    {

        public int TimeDelay { get; set; }
        public string TypeChangeIP { set; get; }
        public List<string> Actions { set; get; } 

    }
}
