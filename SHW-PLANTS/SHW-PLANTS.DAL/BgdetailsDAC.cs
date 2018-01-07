using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHW_PLANTS.DAL
{
    public class BG_DashBoard
    {
        public int ProjectID { get; set; }
        public int BG_ID { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public string Duedate { get; set; }
        public string Status { get; set; }
        public String UserName { get; set; }
        public int Read { get; set; }
        public int Complited { get; set; }
    }
    public class BgdetailsDAC
    {
        public List<BG_DashBoard> GetAllBGDetailsDAC()
        {
            List<BG_DashBoard> BgMaster = new List<BG_DashBoard>();
            try
            {

                using (var db = new PlantsDatabaseEntities())
                {
                    BgMaster = (from bg in db.BGDetails
                                join prj in db.ProjectMasters on bg.ProjectId equals prj.ProjectId
                                join usr in db.UserMasters on bg.BGUserId equals usr.UserId
                         //where date is pending when front end will complete then this will also completed
                                select new BG_DashBoard
                                {
                                    ProjectID = prj.ProjectId,
                                    BG_ID=bg.BGId,
                                    ProjectName=prj.ProjectName,
                                    CustomerName=prj.CustomerName,
                                    Duedate=bg.BGStartDate.ToString(),
                                    Status="Start",
                                    UserName=usr.UserName,
                                    Read=bg.BGStartRead,
                                    Complited=bg.BGCompleted
                                }).ToList();
                }
                return BgMaster;
            }
            catch (Exception EX)
            {
                return null;
            }
        }
        public bool BGReadDAC(int ProjectID, int BgIdBymethod, string Status)
        {
            try
            {
                BGDetail bGDetail = new BGDetail();
               
                using (var ctx = new PlantsDatabaseEntities())
                {
                    bGDetail = ctx.BGDetails.Where(bg => bg.BGId == BgIdBymethod).FirstOrDefault<BGDetail>();
                }
                if (Status.Trim() == "Start")
                {
                    bGDetail.BGStartRead = 1;
                   // bGDetail.BGCompleted = 1;
                }
                else
                {
                    bGDetail.BGEndRead = 1;
                    //bGDetail.BGCompleted = 2;
                }

                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(bGDetail).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }
           
        }
        public bool BGComplitedDAC(int ProjectID, int BgIdBymethod, string Status)
        {
            try
            {
                BGDetail bGDetail = new BGDetail();
                using (var ctx = new PlantsDatabaseEntities())
                {
                    bGDetail = ctx.BGDetails.Where(bg => bg.BGId == BgIdBymethod).FirstOrDefault<BGDetail>();
                }
                if (Status.Trim() == "Start")
                {
                    //bGDetail.BGStartRead = 1;
                     bGDetail.BGCompleted = 1;
                }
                else
                {
                    //bGDetail.BGEndRead = 1;
                    bGDetail.BGCompleted = 2;
                }

                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(bGDetail).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }

        }
    }
}