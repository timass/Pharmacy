using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Pharm.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unit;
        PharmacySPParams ph;
        public HomeController()
        {
            unit = new UnitOfWork();
            ph = new PharmacySPParams();
        }      
       
        public ActionResult Index()
        {
            List<PharmacySPResult> list = unit.pharmacyRepository.GetAll(ph);
            return View(list);
        }         
        
    }
}