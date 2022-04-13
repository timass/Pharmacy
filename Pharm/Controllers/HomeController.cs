using DataLayer;
using Pharm.Extensions;
using BusinessLayer.Extensions;
using System.Collections.Generic;
using System.Web.Mvc;
using System;
using System.Threading.Tasks;

namespace Pharm.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryPharmacy Repos;
        private readonly PharmacyViewModel PhVM;

        public HomeController(IRepositoryPharmacy rep, PharmacyViewModel phVM)
        {
            Repos = rep;
            PhVM = phVM;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
           
            List<PharmacySPResult> list = await Repos.GetAllAsync(PhVM.ToPharmacyDomain().ToPharmacySPParams());            
            List<PharmacyViewModel> newList = new List<PharmacyViewModel>();
            foreach (var item in list)
            {
              newList.Add(item.ToPharmacyDomain().ToPharmacyViewModel());
            }
            return View(newList);
        }                 
    }
}