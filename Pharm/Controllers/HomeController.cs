using System.Web.Mvc;
using System.Threading.Tasks;
using BusinessLayer.Services;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;
using Pharm.Extensions;
using System;

namespace Pharm.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //List<PharmacyDomain> listPharmDom = await PharmacyService.GetAllPharmacies();

            //PharmacyService.Create(new PharmacyViewModel
            //{
            //    PharmacyId = Guid.NewGuid(),
            //    PhName = "NewOne",
            //    StateCode = "AAA",
            //    Address = "AAA",
            //    ContactEmail = "AAA",
            //    ContactPhone = "111"
            //}
            //.ToPharmacyDomain()
            //);

            //PharmacyService.Update(new PharmacyViewModel
            //{
            //    PharmacyId = Guid.Parse("79A912FC-0820-49FF-A4BE-7A163E463E01"),
            //    PhName = "B",
            //    StateCode = "B",
            //    Address = "B",
            //    ContactEmail = "B",
            //    ContactPhone = "B"
            //}
            //.ToPharmacyDomain()
            //);

           // List<PharmacyDomain> listPharmDom = await PharmacyService.GetFiltered(new PharmacyViewModel
           // {               
           //     PharmacyId = Guid.Parse("71136AD7-EF92-4019-8F1D-7EAD78C2E1C6"),                
           // }
           //.ToPharmacyDomain()
           //);
            List<PharmacyDomain> listPharmDom = await PharmacyService.GetAllPharmacies();

            return View(listPharmDom.Select(p=>p.ToPharmacyViewModel()).ToList());           
        }                 
    }
}