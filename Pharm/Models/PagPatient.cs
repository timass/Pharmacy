using System.Collections.Generic;

namespace Pharm.Models
{
    public class PagPatient
    {
        public IEnumerable<WMPatient> Patients { get; set; }

        public PageViewModel PageViewModel { get; set; }
    }
}