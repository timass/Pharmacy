using DataLayer;
using Pharm.Extensions;
using BusinessLayer.Extensions;
using System.Collections.Generic;
using System.Web.Mvc;
using System;

namespace Pharm.Controllers
{
    public class HomeController : Controller
    {
        private readonly RepositoryPharmacy Repos;        
        WMPharmacy WmPh;

        public HomeController() { }

        public HomeController(RepositoryPharmacy rep)
        {
            Repos = rep;
            WmPh = new WMPharmacy();          
        }      
       
        public ActionResult Index()
        {
            //List<PharmacySPResult> list = Repos.GetAll(WmPh.MappFromWMPharmacyToPharmacy().MappFromPharmacyToPhSPParams());

            List<WMPharmacy> newList = new List<WMPharmacy>();
            foreach (var item in Repos.GetAll(WmPh.MappFromWMPharmacyToPharmacy().MappFromPharmacyToPhSPParams()))
            {
                newList.Add(item.MappFromPhSPResultToPharmacy().MappFromPharmacyToWMPharmacy());
            }

            //List<WMPharmacy> newList2 = (from l in list
            //                            select new WMPharmacy (l.MappFromPhSPResultToPharmacy().MappFromPharmacyToWMPharmacy())
            //                            .ToList();               
            return View(newList);
        }         
        
    }
}