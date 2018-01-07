using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHW_PLANTS.DAL
{
    public class UserMasterCLS
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string ContactNumber { get; set; }
        public string UserEmailId { get; set; }

    }
    public class UserDetailsDAC
    {
        public List<UserMasterCLS> GetUsersDAC()
        {
            try
            {
                List<UserMasterCLS> userMaster = new List<UserMasterCLS>();
                using (var db = new PlantsDatabaseEntities())
                {
                    userMaster = ( from d in db.UserMasters
                                  select new UserMasterCLS
                                  {
                                      UserId = d.UserId,
                                      UserName = d.UserName,
                                      ContactNumber = d.ContactNumber,
                                      UserEmailId = d.UserEmailId
                                  }).ToList();
                }
                return userMaster;
            }
            catch (Exception EX)
            {
                return null;
            }
        }
        public bool AddUserDAC(UserMasterCLS userMaster)
        {
            try
            {
                UserMaster userDetails = new UserMaster();
              //  userDetails.UserId = userMaster.UserId;
                userDetails.UserName = userMaster.UserName;
                userDetails.UserEmailId = userMaster.UserEmailId;
                userDetails.ContactNumber = userMaster.ContactNumber;

                using (var db = new PlantsDatabaseEntities())
                {
                    db.UserMasters.Add(userDetails);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }
        }
        public bool EditUserDAC(UserMasterCLS userMaster)
        {
            try
            {
                UserMaster userDetails = new UserMaster();
                using (var ctx = new PlantsDatabaseEntities())
                {
                    userDetails = ctx.UserMasters.Where(u => u.UserId == userMaster.UserId).FirstOrDefault<UserMaster>();
                }
                userDetails.UserName = userMaster.UserName;
                userDetails.UserEmailId = userMaster.UserEmailId;
                userDetails.ContactNumber = userMaster.ContactNumber;

                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(userDetails).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }
        }
        public bool DeleteUserDAC(int userId)
        {
            try
            {
                using (var db = new PlantsDatabaseEntities())
                {
                    UserMaster userDetails = new UserMaster();
                    userDetails.UserId = userId;
                    db.UserMasters.Attach(userDetails);
                    db.UserMasters.Remove(userDetails);
                    db.SaveChanges();
                }
                    return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}