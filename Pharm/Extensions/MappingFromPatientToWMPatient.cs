using BusinessLayer;

using System;

namespace Pharm.Extensions
{
    public static class MappingFromPatientToWMPatient
    {
        public static WMPatient MappFromPatientToWMPatient(this Patient wmPat)
        {
            return new WMPatient
            {
                PatientId = Guid.Parse(nameof(wmPat.PatientId)),
                Name = nameof(wmPat.Name),
                LastName = nameof(wmPat.LastName),
                PharmacyName = nameof(wmPat.PharmacyName)
            };
        }
    }    
}
