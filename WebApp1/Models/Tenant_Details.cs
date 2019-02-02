using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class Tenant_Details
    {
        public string ID { get; set; }
        public string Created_By { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string Job_Function { get; set; }
        public string Document_Path { get; set; }
        [NotMapped]
        public IFormFile Document_Paths { get; set; }

    }
}
