using System;

namespace DataLayer
{
    public class Patient
    {
        public Guid PatientId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string PharmacyName { get; set; }

        public void Reader(PatientSPParams pParams, PatientSPResult pResult)
        {
            PatientId = pParams.PatientId;
            Name = pParams.Name;
            LastName = pParams.LastName;
            PharmacyName = pParams.PharmacyName;            
        }
    }
}
