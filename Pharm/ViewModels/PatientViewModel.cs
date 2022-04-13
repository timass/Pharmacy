using System;

namespace Pharm
{
    public class PatientViewModel
    {
        public Guid PatientId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string PharmacyName { get; set; }       
    }
}
