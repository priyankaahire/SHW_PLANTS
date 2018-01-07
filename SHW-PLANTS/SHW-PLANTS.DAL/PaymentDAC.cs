using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHW_PLANTS.DAL
{
    public class Payment_DashBoard
    {
        public int ProjectID { get; set; }
        public int Payment_ID { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
        public string Duedate { get; set; }
        public String UserName { get; set; }
        public int Read { get; set; }
        public int Complited { get; set; }
    }
    public class PaymentDAC
    {
        public List<Payment_DashBoard> GetAllPaymentDetails()
        {
            List<Payment_DashBoard> paymentDetails = new List<Payment_DashBoard>();
            try
            {

                using (var db = new PlantsDatabaseEntities())
                {
                    paymentDetails = (from p in db.PaymentDetails
                                          join prj in db.ProjectMasters on p.ProjectId equals prj.ProjectId
                                          join usr in db.UserMasters on p.PaymentId equals usr.UserId
                                          //where date is pending when front end will complete then this will also completed
                                          select new Payment_DashBoard
                                          {
                                              ProjectID = prj.ProjectId,
                                              Payment_ID = p.PaymentId,
                                              ProjectName = prj.ProjectName,
                                              CustomerName = prj.CustomerName,
                                              Duedate = p.PaymentDate.ToString(),
                                              UserName = usr.UserName,
                                              Read = p.PaymentRead,
                                              Complited = p.PaymentCompleted
                                          }).ToList();
                }
                return paymentDetails;
            }
            catch (Exception EX)
            {
                return null;
            }
        }
        public bool PaymentRead(int ProjectID, int PaymentIdBymethod)
        {
            try
            {
                PaymentDetail paymentDetail= new PaymentDetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    paymentDetail = ctx.PaymentDetails.Where(p => p.PaymentId== PaymentIdBymethod).FirstOrDefault<PaymentDetail>();
                }
                paymentDetail.PaymentRead= 1;
                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(paymentDetail).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception EX)
            {
                return false;
            }

        }
        public bool PaymentComplited(int ProjectID, int PaymentIdBymethod)
        {
            try
            {
                PaymentDetail paymentDetail = new PaymentDetail();

                using (var ctx = new PlantsDatabaseEntities())
                {
                    paymentDetail = ctx.PaymentDetails.Where(p => p.PaymentId == PaymentIdBymethod).FirstOrDefault<PaymentDetail>();
                }
                paymentDetail.PaymentCompleted = 1;
                DateTime dt = DateTime.Now;
                paymentDetail.PaymentCompletedDate = dt;
                using (var db = new PlantsDatabaseEntities())
                {
                    db.Entry(paymentDetail).State = System.Data.Entity.EntityState.Modified;
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