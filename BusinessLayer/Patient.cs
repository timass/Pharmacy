using System;

namespace BusinessLayer
{
    public class Patient
    {
        public Guid PatientId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string PharmacyName { get; set; }       
    }
}
