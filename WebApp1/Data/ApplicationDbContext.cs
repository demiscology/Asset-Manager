using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Asset_Details> Asset_Details { get; set; }
        public DbSet<Tenant_Details> Tenant_Details { get; set; }
        public DbSet<AssetAllocation> AssetAllocation { get; set; }

    }
}
