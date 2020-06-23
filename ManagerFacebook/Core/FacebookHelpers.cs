using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo.Helpers;
using Facebook;


namespace ManagerFacebook.Core
{
    public static class FacebookHelpers
    {
        public static List<string> GET_UserByPost(string ID,string AccessToken)
        {
            FacebookClient fb = new FacebookClient();

            fb.AccessToken = AccessToken;
            var data = fb.Get(ID+"?fields=likes.limit(500000)");
          
            dynamic t = (data as dynamic)["likes"]["data"];
            List<string> users = new List<string>();
            foreach (var item in t)
            {
                dynamic user = item as dynamic;
                users.Add(user["id"]+"|"+user["name"]);

            }
            
            return users;
        }

        public static List<string> GET_ListFriends(string ID, string AccessToken)
        {
            FacebookClient fb = new FacebookClient();

            fb.AccessToken = AccessToken;
            var data = fb.Get(ID + "/friends?fields=id,name&limit=5000");

            dynamic t = (data as dynamic)["data"];
            List<string> users = new List<string>();
            foreach (var item in t)
            {
                dynamic user = item as dynamic;
                users.Add(user["id"] + "|" + user["name"]);

            }

            return users;
        }
        //public static List<string> GET_ListFriends(string ID, string AccessToken)
        //{
        //    FacebookClient fb = new FacebookClient();

        //    fb.AccessToken = AccessToken;
        //    var acc = fb.Get("100052087272127?fields=id,birthday,gender,name");
        //    var friends = fb.Get("100052121980233/friends?fields=id,name&limit=5000");
        //    var photo = fb.Get("100052121980233/groups?fields=id,name&limit=50000");
        //    dynamic t = (photo as dynamic)["data"][1];
        //    var name = t["name"];
        //}
    }
}
