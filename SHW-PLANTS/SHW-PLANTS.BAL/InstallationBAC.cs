using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHW_PLANTS.DAL;
namespace SHW_PLANTS.BAL
{
    public class InstallationBAC
    {
        public List<Installation_DashBoard> GetInstallationDetailsBAC()
        {
            installationDAC installationDAC = new installationDAC();
            return installationDAC.GetAllInstallationDetails();
        }
        public bool InstallationReadBAC(int ProjectID, int InstallationID)
        {
            installationDAC installationDAC = new installationDAC();
            return installationDAC.InstallationRead(ProjectID, InstallationID);
        }
        public bool InstallationComplitedBAC(int ProjectID, int InstallationID)
        {
            installationDAC installationDAC = new installationDAC();
            return installationDAC.InstallationComplited(ProjectID, InstallationID);
        }

    }
}