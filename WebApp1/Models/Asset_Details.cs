using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class Asset_Details
    {
        public string ID { get; set; }
        public string Created_By { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Gender { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Brief_Description { get; set; }
        public string  Asset_Type { get; set; }
        public string Flat_Block_Number { get; set; }
        public string Documents_Path { get; set; }
        [NotMapped]
        public IFormFile Document_Paths { get; set; }
        public string Allocated { get; set; }
    }
}
