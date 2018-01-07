using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SHW_PLANTS.BAL;
using SHW_PLANTS.DAL;
using System.Web.Services;

namespace SHW_PLANTS.WebApp.src.Dashboard
{
    public partial class BGDetailsWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<BG_DashBoard> GetBGDetail()
        {
            BGdetailsBAC bGdetailsBAC = new BGdetailsBAC();
            return bGdetailsBAC.GetBgDetailsBAC();
        }
        [WebMethod]
        public static string BG_read(string ProjectId,string BgId,string Status)
        {
            BGdetailsBAC bGdetailsBAC = new BGdetailsBAC();
            if (bGdetailsBAC.BgReadBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(BgId), Status))
                return "Success";
            else
                return "Failed to Set";
        }
        [WebMethod]
        public static string BG_Complit(string ProjectId, string BgId, string Status)
        {
            BGdetailsBAC bGdetailsBAC = new BGdetailsBAC();
            if (bGdetailsBAC.BgComplitedBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(BgId), Status))
                return "Success";
            else
                return "Failed to Set";
        }
    }
}