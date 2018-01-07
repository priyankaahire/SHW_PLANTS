using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHW_PLANTS.DAL;

namespace SHW_PLANTS.BAL
{
    public class LDdetailsBAC
    {
        public List<LD_DashBoard> GetLdDetailsBAC()
        {
            LDdetailsDAC LddetailsDAC = new LDdetailsDAC();
            return LddetailsDAC.GetAllLDDetails();
        }
        public bool LDReadBAC(int ProjectID, int Ldid)
        {
            LDdetailsDAC LddetailsDAC = new LDdetailsDAC();
            return LddetailsDAC.LDRead(ProjectID, Ldid);
        }
        public bool BgComplitedBAC(int ProjectID, int Ldid)
        {
            LDdetailsDAC LddetailsDAC = new LDdetailsDAC();

            return LddetailsDAC.LDComplited(ProjectID,Ldid);
        }

    }
}