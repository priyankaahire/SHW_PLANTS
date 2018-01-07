using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHW_PLANTS.DAL;

namespace SHW_PLANTS.BAL
{
    public class PaymentBAC
    {
        public List<Payment_DashBoard> GetPaymentBAC()
        {
            PaymentDAC paymentDAC = new PaymentDAC();
            return paymentDAC.GetAllPaymentDetails();
        }
        public bool PaymentReadBAC(int ProjectID, int PaymentId)
        {
            PaymentDAC paymentDAC = new PaymentDAC();
            return paymentDAC.PaymentComplited(ProjectID, PaymentId);
        }
        public bool PaymentComplitedBAC(int ProjectID, int PaymentId)
        {
            PaymentDAC paymentDAC = new PaymentDAC();
            return paymentDAC.PaymentComplited(ProjectID, PaymentId);
        }
    }
}