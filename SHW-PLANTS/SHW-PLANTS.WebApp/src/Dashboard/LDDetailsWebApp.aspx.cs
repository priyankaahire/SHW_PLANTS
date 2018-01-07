using SHW_PLANTS.BAL;
using SHW_PLANTS.DAL;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace SHW_PLANTS.WebApp.src.Dashboard
{
    public partial class LDDetailsWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<LD_DashBoard> GetLDDetail()
        {
            LDdetailsBAC lDdetailsBAC = new LDdetailsBAC();
            return lDdetailsBAC.GetLdDetailsBAC();
        }
        [WebMethod]
        public static string LD_read(string ProjectId, string LD_Id)
        {
            LDdetailsBAC lDdetailsBAC = new LDdetailsBAC();
            if (lDdetailsBAC.LDReadBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(LD_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }
        [WebMethod]
        public static string LD_Complit(string ProjectId, string LD_Id)
        {
            LDdetailsBAC lDdetailsBAC = new LDdetailsBAC();
            if (lDdetailsBAC.BgComplitedBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(LD_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }

    }
}