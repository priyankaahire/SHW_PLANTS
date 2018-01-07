using SHW_PLANTS.BAL;
using SHW_PLANTS.DAL;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace SHW_PLANTS.WebApp.src.Dashboard
{
    public partial class DeliveryWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<Delivery_DashBoard> GetDeliveryDetail()
        {
            DeliveryBAC delivery= new DeliveryBAC();
            return delivery.GetDeliveryDetailsBAC();
        }
        [WebMethod]
        public static string Delivery_read(string ProjectId, string Delivery_Id)
        {
            DeliveryBAC delivery = new DeliveryBAC();
            if (delivery.DeliveryReadBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(Delivery_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }
        [WebMethod]
        public static string Delivery_Complit(string ProjectId, string Delivery_Id)
        {
            DeliveryBAC delivery = new DeliveryBAC();
            if (delivery.DeliveryComplitedBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(Delivery_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }
    }
}
