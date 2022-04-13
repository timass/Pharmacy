using System.Collections.Generic;

namespace Pharm.Models
{
    public class FiltrPharmacies
    {
        public IEnumerable<WMPharmacy> Patients { get; set; }

        public string Name { get; set; }
    }
}