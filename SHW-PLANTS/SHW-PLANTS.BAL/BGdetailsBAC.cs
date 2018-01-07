using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHW_PLANTS.DAL;

namespace SHW_PLANTS.BAL
{
    public class BGdetailsBAC
    {
        public List<BG_DashBoard> GetBgDetailsBAC()
        {
            BgdetailsDAC bgdetailsDAC = new BgdetailsDAC();
            return bgdetailsDAC.GetAllBGDetailsDAC();
                
        }
        public bool BgReadBAC(int ProjectID, int BgIdBymethod, string Status)
        {
            BgdetailsDAC bgdetailsDAC = new BgdetailsDAC();
            return bgdetailsDAC.BGReadDAC(ProjectID, BgIdBymethod, Status);
        }
        public bool BgComplitedBAC(int ProjectID, int BgIdBymethod, string Status)
        {
            BgdetailsDAC bgdetailsDAC = new BgdetailsDAC();
            return bgdetailsDAC.BGComplitedDAC(ProjectID, BgIdBymethod, Status);
        }

    }
}