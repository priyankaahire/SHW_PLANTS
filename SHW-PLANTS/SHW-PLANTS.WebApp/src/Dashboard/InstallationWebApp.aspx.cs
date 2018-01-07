using SHW_PLANTS.BAL;
using SHW_PLANTS.DAL;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace SHW_PLANTS.WebApp.src.Dashboard
{
    public partial class InstallationWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<Installation_DashBoard> GetInstallationDetail()
        {
            InstallationBAC installationBAC = new InstallationBAC();
            return installationBAC.GetInstallationDetailsBAC();
        }
        [WebMethod]
        public static string Installation_read(string ProjectId, string Installation_Id)
        {
            InstallationBAC installationBAC = new InstallationBAC();
            if (installationBAC.InstallationReadBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(Installation_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }
        [WebMethod]
        public static string Delivery_Complit(string ProjectId, string Installation_Id)
        {
            InstallationBAC installationBAC = new InstallationBAC();
            if (installationBAC.InstallationComplitedBAC(Convert.ToInt32(ProjectId), Convert.ToInt32(Installation_Id)))
                return "Success";
            else
                return "Failed to Set Read";
        }

    }
}