using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class ManageAssetsAllocation
    {
        public string Id { get; set; }
        public string AssetName { get; set; }
        public string AssetBreif { get; set; }
        public string AssetAddress { get; set; }
        public string TenantName { get; set; }
        public string TenantAddress { get; set; }
        public string TenantNumber { get; set; }
    }
}
