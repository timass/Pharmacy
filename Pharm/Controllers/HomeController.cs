using System.Web.Mvc;
using System.Threading.Tasks;
using BusinessLayer.Services;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;
using Pharm.Extensions;

namespace Pharm.Controllers
{
    public class HomeController : Controller
    {
        PharmacyService PhSer = new PharmacyService();
        [HttpGet]
        public async Task<ActionResult> Index()
        {
           List<PharmacyDomain> listPharmDom = await PhSer.GetAllPharmacy();
           return View(listPharmDom.Select(p=>p.ToPharmacyViewModel()).ToList());
        }                 
    }
}