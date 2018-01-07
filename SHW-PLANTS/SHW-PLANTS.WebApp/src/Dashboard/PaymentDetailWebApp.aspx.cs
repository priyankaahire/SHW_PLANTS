using SHW_PLANTS.BAL;
using SHW_PLANTS.DAL;
using System;
using System.Collections.Generic;
using System.Web.Services;
namespace SHW_PLANTS.WebApp.src.Dashboard
{
    public partial class PaymentDetailWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<Payment_DashBoard> GetPaymentDetail()
        {
            PaymentBAC paymentBAC = new PaymentBAC();
            return paymentBAC.GetPaymentBAC();
        }
        [WebMethod]
        public static string Payment_read(string ProjectId, string Payment_Id)
        {
            PaymentBAC paymentBAC = new PaymentBAC();
            if (paymentBAC.PaymentReadBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(Payment_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }
        [WebMethod]
        public static string Payment_Complit(string ProjectId, string Payment_Id)
        {
            PaymentBAC paymentBAC = new PaymentBAC();
            if (paymentBAC.PaymentComplitedBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(Payment_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }
    }
}