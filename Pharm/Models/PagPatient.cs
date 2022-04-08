using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharm.Models
{
    public class PagPatient
    {
        public IEnumerable<PatientSPParams> Patients { get; set; }

        public PageViewModel PageViewModel { get; set; }
    }
}