using SHW_PLANTS.BAL;
using SHW_PLANTS.DAL;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace SHW_PLANTS.WebApp.src.Users
{
    public partial class UserMaster : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<UserMasterCLS> GetAllUsers()
        {
            List<UserMasterCLS> dbuserMaster = new List<UserMasterCLS>();
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            dbuserMaster = userDetailsBac.GetUsersBAC();
            //return JsonConvert.SerializeObject(dbuserMaster);
            return dbuserMaster;
        }
        [WebMethod]
        public static string AddUser(string UserId, string UserName, string UserEmailId, string ContactNumber)
        {
            UserMasterCLS userMaster = new UserMasterCLS();
            userMaster.UserName = UserName;
            userMaster.UserEmailId = UserEmailId;
            userMaster.ContactNumber = ContactNumber;
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            return userDetailsBac.AddUserBAC(userMaster).ToString();
            //return "Success";
        }
        [WebMethod]
        public static string EditUser(string UserId, string UserName, string UserEmailId, string ContactNumber)
        {
            UserMasterCLS userMaster = new UserMasterCLS();
            userMaster.UserId = Convert.ToInt32(UserId);
            userMaster.UserName = UserName;
            userMaster.UserEmailId = UserEmailId;
            userMaster.ContactNumber = ContactNumber;
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            return userDetailsBac.EditUserBAC(userMaster).ToString();
        }

        [WebMethod]
        public static bool DeleteUser(string id)
        {
            UserDetailsBac userDetailsBac = new UserDetailsBac();
            return userDetailsBac.DeleteUserBAC(Convert.ToInt32(id));
        }
    }
}