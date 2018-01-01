using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHW_PLANTS.DAL;

namespace SHW_PLANTS.BAL
{
    public class UserDetailsBac
    {
        public List<UserMasterCLS> GetUsersBAC()
        {
            List<UserMasterCLS> userMaster = new List<UserMasterCLS>();
            UserDetailsDAC userDetailsDAC = new UserDetailsDAC();
            userMaster = userDetailsDAC.GetUsersDAC();
            return userMaster;
        }
        public bool AddUserBAC(UserMasterCLS userMaster)
        {
            UserDetailsDAC userDetailsDAC = new UserDetailsDAC();
            return userDetailsDAC.AddUserDAC(userMaster);
        }
        public bool EditUserBAC(UserMasterCLS userMaster)
        {
            UserDetailsDAC userDetailsDAC = new UserDetailsDAC();
            return userDetailsDAC.EditUserDAC(userMaster);
        }
        public bool DeleteUserBAC(int userId)
        {
            UserDetailsDAC userDetailsDAC = new UserDetailsDAC();
            return userDetailsDAC.DeleteUserDAC(userId);
        }
    }
}