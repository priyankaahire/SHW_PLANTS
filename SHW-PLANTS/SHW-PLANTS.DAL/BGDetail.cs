//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SHW_PLANTS.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BGDetail
    {
        public int BGId { get; set; }
        public int ProjectId { get; set; }
        public System.DateTime BGStartDate { get; set; }
        public int BGStartMail { get; set; }
        public int BGStartRead { get; set; }
        public int BGCompleted { get; set; }
        public System.DateTime BGEndDate { get; set; }
        public int BGEndMail { get; set; }
        public int BGEndRead { get; set; }
        public int BGUserId { get; set; }
    
        public virtual ProjectMaster ProjectMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}