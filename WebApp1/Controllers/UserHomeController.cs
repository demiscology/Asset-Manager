using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp1.Data;
using WebApp1.Models;
using System.IO;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using WebApp1.Areas.Identity.Pages.Account;

namespace WebApp1.Controllers
{
    [Authorize]
    public class UserHomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IHostingEnvironment _ihostingEnviroment;
        private readonly ILogger _logger;

        private ApplicationDbContext _db;

        public UserHomeController(ApplicationDbContext db,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IHostingEnvironment hostingEnvironment,
            ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _ihostingEnviroment = hostingEnvironment;
            _db = db;
            _logger = logger;
        }


        public IActionResult Index()
        {
            var num_tenants = _db.Tenant_Details.Count().ToString();
            var num_assets = _db.Asset_Details.Count().ToString();
            var num_allocated = _db.AssetAllocation.Count().ToString();

            ViewData["num_tenants"] = num_tenants;
            ViewData["num_assets"] = num_assets;
            ViewData["num_allocated"] = num_allocated;
            var count = 0;

            var allocated = _db.AssetAllocation.ToArray();

            List<IndexViewModel> vs = new List<IndexViewModel>();


            foreach (var allocated_asset in allocated)
            {
                DateTime date = DateTime.ParseExact(allocated_asset.End_Date, "mm/dd/yyyy", null);
                var date1 = DateTime.ParseExact(DateTime.Today.ToString("mm/dd/yyyy"), "mm/dd/yyyy", null);
                var compare = DateTime.Compare(date, date1);


                if (compare < 0)
                {
                    IndexViewModel index = new IndexViewModel
                    {
                        TenantName = _db.Tenant_Details.Find(allocated_asset.TenantId).First_Name + " " + _db.Tenant_Details.Find(allocated_asset.TenantId).Last_Name,
                        AssetName = _db.Asset_Details.Find(allocated_asset.AssetID).First_Name + " " + _db.Asset_Details.Find(allocated_asset.AssetID).Last_Name,
                        Date = date.ToString(),
                        Exp_State = compare.ToString()
                    };

                    vs.Add(index);
                    count++;
                }
                else
                {
                    IndexViewModel index = new IndexViewModel
                    {
                        TenantName = _db.Tenant_Details.Find(allocated_asset.TenantId).First_Name + " " + _db.Tenant_Details.Find(allocated_asset.TenantId).Last_Name,
                        AssetName = _db.Asset_Details.Find(allocated_asset.AssetID).First_Name + " " + _db.Asset_Details.Find(allocated_asset.AssetID).Last_Name,
                        Date = date.ToString(),
                        Exp_State = compare.ToString()
                    };
                    vs.Add(index);
                }


            }
            ViewData["num_paymentsdue"] = count;
            vs.ToArray();
            return View(vs);
        }

        public IActionResult AddNewAsset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAsset(Asset_Details details)
        {
            var userId = _userManager.GetUserId(User);
            var totalfile = "";
            if (details.Document_Paths != null)
            {
                var files = HttpContext.Request.Form.Files;

                foreach (var f in files)
                {
                    var uniqueFileName = GetUniqueFileName(f.FileName);
                    var uploads = Path.Combine(_ihostingEnviroment.WebRootPath, "Documents");
                    var Filepath = Path.Combine(uploads, uniqueFileName);
                    using (var filestream = new FileStream(Filepath, FileMode.Create))
                    {
                        f.CopyTo(filestream);
                    }
                    //f.CopyTo(new FileStream(Filepath, FileMode.Create));

                    totalfile = totalfile + uniqueFileName + " ,";
                }
            }
            Asset_Details asset = new Asset_Details
            {
                ID = Guid.NewGuid().ToString(),
                Created_By = _userManager.GetUserId(User),
                First_Name = details.First_Name,
                Last_Name = details.Last_Name,
                Middle_Name = details.Middle_Name,
                Gender = details.Gender,
                Phone_Number = details.Phone_Number,
                Address = details.Address,
                Location = details.Location,
                Brief_Description = details.Brief_Description,
                Asset_Type = details.Asset_Type,
                Flat_Block_Number = details.Flat_Block_Number,
                Documents_Path = totalfile,
                Allocated = "0"
            };

            _db.Asset_Details.Add(asset);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult AddNewTenants()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTenants(Tenant_Details tenant_Details)
        {
            var userId = _userManager.GetUserId(User);
            var totalfile = "";
            if (tenant_Details.Document_Paths != null)
            {
                var files = HttpContext.Request.Form.Files;

                foreach (var f in files)
                {
                    var uniqueFileName = GetUniqueFileName(f.FileName);
                    var uploads = Path.Combine(_ihostingEnviroment.WebRootPath, "Documents");
                    var Filepath = Path.Combine(uploads, uniqueFileName);
                    using (var filestream = new FileStream(Filepath, FileMode.Create))
                    {
                        f.CopyTo(filestream);
                    }
                    //f.CopyTo(new FileStream(Filepath, FileMode.Create));

                    totalfile = totalfile + uniqueFileName + " ,";
                }
            }

            Tenant_Details details = new Tenant_Details
            {
                ID = Guid.NewGuid().ToString(),
                Created_By = userId,
                First_Name = tenant_Details.First_Name,
                Last_Name = tenant_Details.Last_Name,
                Middle_Name = tenant_Details.Last_Name,
                Gender = tenant_Details.Gender,
                DOB = tenant_Details.DOB,
                Address = tenant_Details.Address,
                Location = tenant_Details.Location,
                Phone_Number = tenant_Details.Phone_Number,
                Email = tenant_Details.Email,
                Job_Function = tenant_Details.Job_Function,
                Document_Path = totalfile

            };
            _db.Tenant_Details.Add(details);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        private string GetUniqueFileName(string FileName)
        {
            FileName = Path.GetFileName(FileName);
            FileName = string.Join("", FileName.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            return Path.GetFileNameWithoutExtension(FileName) + "_"
                + Guid.NewGuid().ToString().Substring(0, 4)
                + Path.GetExtension(FileName);
        }

        public IActionResult AssetsAllocation()
        {
            var tenants = _db.Tenant_Details.ToArray();
            var assets = _db.Asset_Details.ToArray();
            string[] tenants_details = new string[tenants.Count()];

            int i = 0;
            int j = 0;
            int count = 0;
            foreach (var x in tenants)
            {
                tenants_details[i] = x.First_Name + " " + x.Last_Name + " " + x.Gender + " " + x.Address + " " + x.ID;
                i++;
            }
            foreach (var z in assets)
            {
                if (z.Allocated == "0")
                {
                    count += 1;
                    //assets_details[j] = z.Brief_Description + " " + z.Flat_Block_Number + " " + z.Asset_Type + " " + z.Address + " " + z.ID;
                }
            }

            string[] assets_details = new string[count];
            foreach (var z in assets)
            {
                if (z.Allocated == "0")
                {
                    assets_details[j] = z.Brief_Description + " " + z.Flat_Block_Number + " " + z.Asset_Type + " " + z.Address + " " + z.ID;

                    j += 1;

                }
            }


            ViewData["assets"] = assets_details;
            ViewData["tenants"] = tenants_details;

            return View();
        }

        [HttpPost]
        public IActionResult AssetsAllocation(AssetAllocation assetAllocation)
        {
            var userid = _userManager.GetUserId(User);

            var Asset_id = assetAllocation.AssetID.Substring(assetAllocation.AssetID.Length - 36);
            var tenant_Id = assetAllocation.TenantId.Substring(assetAllocation.TenantId.Length - 36);

            var check = _db.Asset_Details.Find(Asset_id);
            check.Allocated = "1";

            AssetAllocation asset = new AssetAllocation
            {
                ID = Guid.NewGuid().ToString(),
                CreatedBy = userid,
                TenantId = tenant_Id,
                AssetID = Asset_id,
                Start_Date = assetAllocation.Start_Date.ToString(),
                End_Date = assetAllocation.End_Date.ToString(),
                Due_Payment = assetAllocation.Due_Payment

            };

            _db.AssetAllocation.Add(asset);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult ManageAssetsAllocation()
        {

            IQueryable<ManageAssetsAllocation> assetsAllocations =
                from AssetAllocation in _db.AssetAllocation
                join Asset_Details in _db.Asset_Details on AssetAllocation.AssetID equals Asset_Details.ID
                join Tenant_Details in _db.Tenant_Details on AssetAllocation.TenantId equals Tenant_Details.ID
                select new ManageAssetsAllocation
                {
                    AssetName = Asset_Details.First_Name + " " + Asset_Details.Last_Name,
                    AssetBreif = Asset_Details.Brief_Description,
                    AssetAddress = Asset_Details.Address,
                    TenantAddress = Tenant_Details.Address,
                    TenantName = Tenant_Details.First_Name + " " + Tenant_Details.Last_Name,
                    TenantNumber = Tenant_Details.Phone_Number,
                    Id = AssetAllocation.ID,
                    RentExp = AssetAllocation.End_Date.ToString()
                };

            return View(assetsAllocations);

        }

        [HttpPost]
        public JsonResult ManageAssetsAllocation(string data)
        {
            bool check = false;
            try
            {
                var _User = _db.AssetAllocation.Find(data);
                _db.AssetAllocation.Remove(_User);
                _db.Asset_Details.Find(_User.AssetID).Allocated = "0";
                _db.SaveChanges();
                check = true;

            }
            catch (Exception e)
            {
                throw e;
            }
            return Json(check);
        }

        public IActionResult ManageAsset()
        {
            var assets = _db.Asset_Details.ToArray();
            return View(assets);
        }

        [HttpPost]
        public IActionResult ManageAsset(string data)
        {
            bool check = false;

            try
            {
                var _User = _db.Asset_Details.Find(data);

                if (_User.Allocated == "1")
                {
                    var asset_allocations = _db.AssetAllocation.ToArray();
                    foreach (var asset in asset_allocations)
                    {
                        if (asset.AssetID == _User.ID)
                        {
                            _db.AssetAllocation.Remove(asset);
                        }
                    }
                }

                _db.Asset_Details.Remove(_User);
                _db.SaveChanges();
                check = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return Json(check);
        }

        public IActionResult ManageTenants()
        {
            var tenants = _db.Tenant_Details.ToArray();
            return View(tenants);
        }

        [HttpPost]
        public IActionResult ManageTenants(string data)
        {
            bool check = false;

            try
            {
                var _User = _db.Tenant_Details.Find(data);
                _db.Tenant_Details.Remove(_User);
                _db.SaveChanges();
                check = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return Json(check);
        }

    }
}