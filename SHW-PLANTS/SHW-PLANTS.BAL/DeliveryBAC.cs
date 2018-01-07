using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHW_PLANTS.DAL;


namespace SHW_PLANTS.BAL
{
    public class DeliveryBAC
    {
        public List<Delivery_DashBoard> GetDeliveryDetailsBAC()
        {
            DeliveryDAC deliveryDAC = new DeliveryDAC();
            return deliveryDAC.GetAllDeliveryDetailsDAC();
        }
        public bool DeliveryReadBAC(int ProjectID, int BgIdBymethod)
        {
            DeliveryDAC deliveryDAC = new DeliveryDAC();
            return deliveryDAC.DeliveryReadDAC(ProjectID, BgIdBymethod);
        }
        public bool DeliveryComplitedBAC(int ProjectID, int BgIdBymethod)
        {
            DeliveryDAC deliveryDAC = new DeliveryDAC();
            return deliveryDAC.DeliveryComplitedDAC(ProjectID, BgIdBymethod);
        }

    }
}