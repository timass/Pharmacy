using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharm.Models
{
    public class PagPharmacy
    {
        public IEnumerable<PharmacySPParams> Patients { get; set; }

        public PageViewModel PageViewModel { get; set; }
    }
}