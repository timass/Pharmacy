using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharm.Controllers
{
    public class BaseController : Controller
    {
        public readonly PharmacyService PharmacyService;

        public BaseController()
        {
            PharmacyService = new PharmacyService();
        }        
    }
}
    