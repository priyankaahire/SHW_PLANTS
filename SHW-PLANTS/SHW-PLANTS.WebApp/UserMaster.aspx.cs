using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Http;
using System.Web.Services;
//using System.Web.Script.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using SHW_PLANTS.DAL;
using SHW_PLANTS.BAL;
using Newtonsoft.Json;
using System.Web;

namespace SHW_PLANTS.WebApp.src.Users
{
    public partial class UserMaster : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]

        public static string GetAllUsers()
        {
            List<UserMasterCLS> dbuserMaster = new List<UserMasterCLS>();
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            dbuserMaster = userDetailsBac.GetUsersBAC();
            return JsonConvert.SerializeObject(dbuserMaster);
            //return dbuserMaster;
        }
        [WebMethod]
        public static bool AddUser(UserMasterCLS userMaster)
        {
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            return userDetailsBac.AddUserBAC(userMaster);
        }
        [WebMethod]
        public static bool EditUser(UserMasterCLS userMaster)
        {
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            return userDetailsBac.EditUserBAC(userMaster);
        }

        [WebMethod]
        public static bool DeleteUser(string id)
        {
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            return userDetailsBac.DeleteUserBAC(Convert.ToInt32(id)); s
        }
    }
}