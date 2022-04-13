using System.Collections.Generic;

namespace Pharm.Models
{
    public class PagPharmacy
    {
        public IEnumerable<WMPharmacy> Patients { get; set; }

        public PageViewModel PageViewModel { get; set; }
    }
}