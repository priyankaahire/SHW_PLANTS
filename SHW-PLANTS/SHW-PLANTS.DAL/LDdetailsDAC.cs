using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHW_PLANTS.DAL
{
    public class LD_DashBoard
    {
        public int ProjectID { get; set; }
        public int LD_ID { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public string Duedate { get; set; }
        public String UserName { get; set; }
        public int Read { get; set; }
        public int Complited { get; set; }
    }
    public class LDdetailsDAC
    {
        public List<LD_DashBoard> GetAllLDDetails()
        {
            List<LD_DashBoard> BgMaster = new List<LD_DashBoard>();
            try
            {

                using (var db = new PlantsDatabaseEntities())
                {
                    BgMaster = (from LD in db.LDDdetails
                                join prj in db.ProjectMasters on LD.ProjectId equals prj.ProjectId
                                join usr in db.UserMasters on LD.LDUserId equals usr.UserId
                                //where date is pending when front end will complete then this will also completed
                                select new LD_DashBoard
                                {
                                    ProjectID = prj.ProjectId,
                                    LD_ID = LD.LDId,
                                    ProjectName = prj.ProjectName,
                                    CustomerName = prj.CustomerName,
                                    Duedate = LD.LDDueDate.ToString(),
                                    UserName = usr.UserName,
                                    Read = LD.LDRead,
                                    Complited = LD.LDComplited
                                }).ToList();
                }
                return BgMaster;
            }
            catch (Exception EX)
            {
                return null;
            }
        }
        public bool LDRead(int ProjectID, int LDIdBymethod)
        {
            try
            {
                LDDdetail lDDetail = new LDDdetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    lDDetail = ctx.LDDdetails.Where(ld => ld.LDId == LDIdBymethod).FirstOrDefault<LDDdetail>();
                }
                
                    lDDetail.LDRead = 1;
                    
                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(lDDetail).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }

        }
        public bool LDComplited(int ProjectID, int LDIdBymethod)
        {
            try
            {
                LDDdetail lDDetail = new LDDdetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    lDDetail = ctx.LDDdetails.Where(ld => ld.LDId == LDIdBymethod).FirstOrDefault<LDDdetail>();
                }

                lDDetail.LDComplited = 1;
                DateTime dt = DateTime.Now;
                lDDetail.LDCompletedDate = dt;

                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(lDDetail).State = System.Data.Entity.EntityState.Modified;
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