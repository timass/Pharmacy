using System.Collections.Generic;

namespace Pharm.Models
{
    public class FiltrPatient
    {
        public IEnumerable<WMPatient> Patients { get; set; }

        public string Name { get; set; }
    }
}