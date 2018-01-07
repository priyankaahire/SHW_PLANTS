using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHW_PLANTS.DAL
{
    public class Installation_DashBoard
    {
        public int ProjectID { get; set; }
        public int Installation_ID { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public string Duedate { get; set; }
        public String UserName { get; set; }
        public int Read { get; set; }
        public int Complited { get; set; }
    }
    public class installationDAC
    {
        public List<Installation_DashBoard> GetAllInstallationDetails()
        {
            List<Installation_DashBoard> installationMaster = new List<Installation_DashBoard>();
            try
            {

                using (var db = new PlantsDatabaseEntities())
                {
                    installationMaster = (from i in db.InstallationDetails
                                      join prj in db.ProjectMasters on i.ProjectId equals prj.ProjectId
                                      join usr in db.UserMasters on i.InstallationUserId equals usr.UserId
                                      //where date is pending when front end will complete then this will also completed
                                      select new Installation_DashBoard
                                      {
                                          ProjectID = prj.ProjectId,
                                          Installation_ID = i.InstallationId,
                                          ProjectName = prj.ProjectName,
                                          CustomerName = prj.CustomerName,
                                          Duedate = i.InstallationDate.ToString(),
                                          UserName = usr.UserName,
                                          Read = i.InstalllationRead,
                                          Complited = i.InstallationCompleted
                                      }).ToList();
                }
                return installationMaster;
            }
            catch (Exception EX)
            {
                return null;
            }
        }
        public bool InstallationRead(int ProjectID, int InstallationIdBymethod)
        {
            try
            {
                InstallationDetail installationDetails = new InstallationDetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    installationDetails = ctx.InstallationDetails.Where(i => i.InstallationId== InstallationIdBymethod).FirstOrDefault<InstallationDetail>();
                }
                installationDetails.InstalllationRead = 1;
                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(installationDetails).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }

        }
        public bool InstallationComplited(int ProjectID, int InstallationIdBymethod)
        {

            try
            {
                InstallationDetail installationDetails = new InstallationDetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    installationDetails = ctx.InstallationDetails.Where(i => i.InstallationId == InstallationIdBymethod).FirstOrDefault<InstallationDetail>();
                }
                installationDetails.InstallationCompleted= 1;
                DateTime dt = DateTime.Now;
                installationDetails.InstallationCompletedDate = dt;

                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(installationDetails).State = System.Data.Entity.EntityState.Modified;
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