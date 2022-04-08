using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharm.Models
{
    public class FiltrPatient
    {
        public IEnumerable<Patient> Patients { get; set; }

        public string Name { get; set; }
    }
}