using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharm.Models
{
    public class FiltrPharmacies
    {
        public IEnumerable<Pharmacy> Patients { get; set; }

        public string Name { get; set; }
    }
}