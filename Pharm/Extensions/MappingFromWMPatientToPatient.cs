using BusinessLayer;
using System;

namespace Pharm.Extensions
{
    public static class MappingFromWMPatientToPatient
    {
        public static Patient MappFromWMPatientToPatient(this WMPatient pat)
        {
            return new Patient
            {
                PatientId = Guid.Parse(nameof(pat.PatientId)),
                Name = nameof(pat.Name),
                LastName = nameof(pat.LastName),
                PharmacyName = nameof(pat.PharmacyName)

            };
        }
    }
}
