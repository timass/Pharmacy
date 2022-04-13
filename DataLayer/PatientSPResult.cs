using System;

namespace DataLayer
{
    public class PatientSPResult
    {
        public Guid PatientId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string PharmacyName { get; set; }
    }
}
