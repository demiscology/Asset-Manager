using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class AssetAllocation
    {
        public string ID { get; set; }
        public string AssetID { get; set; }
        public string TenantId { get; set; }
        public string CreatedBy { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Due_Payment { get; set; }
    }
}
