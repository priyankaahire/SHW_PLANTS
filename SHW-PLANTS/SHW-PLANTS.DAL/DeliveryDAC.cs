using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHW_PLANTS.DAL
{
    public class Delivery_DashBoard
    {
        public int ProjectID { get; set; }
        public int Delivery_ID { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public string Duedate { get; set; }
        public String UserName { get; set; }
        public int Read { get; set; }
        public int Complited { get; set; }
    }
    public class DeliveryDAC
    {
        public List<Delivery_DashBoard> GetAllDeliveryDetailsDAC()
        {
            List<Delivery_DashBoard> deliveryMaster = new List<Delivery_DashBoard>();
            try
            {

                using (var db = new PlantsDatabaseEntities())
                {
                    deliveryMaster = (from d in db.DeliveryDetails
                                      join prj in db.ProjectMasters on d.ProjectId equals prj.ProjectId
                                      join usr in db.UserMasters on d.DeliveryUserId equals usr.UserId
                                      //where date is pending when front end will complete then this will also completed
                                      select new Delivery_DashBoard
                                      {
                                          ProjectID = prj.ProjectId,
                                          Delivery_ID = d.DeliveryId,
                                          ProjectName = prj.ProjectName,
                                          CustomerName = prj.CustomerName,
                                          Duedate = d.DeliveryDate.ToString(),
                                          UserName = usr.UserName,
                                          Read = d.DeliveryRead,
                                          Complited = d.DeliveryCompleted
                                      }).ToList();
                }
                return deliveryMaster;
            }
            catch (Exception EX)
            {
                return null;
            }
        }
        public bool DeliveryReadDAC(int ProjectID, int DeliveryIdBymethod)
        {
            try
            {
                DeliveryDetail deliveryMaster = new DeliveryDetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    deliveryMaster = ctx.DeliveryDetails.Where(d => d.DeliveryId == DeliveryIdBymethod).FirstOrDefault<DeliveryDetail>();
                }
                deliveryMaster.DeliveryRead = 1;
                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(deliveryMaster).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }

        }
        public bool DeliveryComplitedDAC(int ProjectID, int DeliveryIdBymethod)
        {
            try
            {
                DeliveryDetail deliveryMaster = new DeliveryDetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    deliveryMaster = ctx.DeliveryDetails.Where(d => d.DeliveryId == DeliveryIdBymethod).FirstOrDefault<DeliveryDetail>();
                }
                deliveryMaster.DeliveryCompleted = 1;
                DateTime dt = DateTime.Now;
                deliveryMaster.DeliveryCompletedDate = dt;
                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(deliveryMaster).State = System.Data.Entity.EntityState.Modified;
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