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
        public HomeController()
        {
            unit = new UnitOfWork();
        }      
       
        public void Index()
        {
            IEnumerable<Pharmacy> list = unit.pharmacyRepository.GetAll();
        } 
        
        
    }
}