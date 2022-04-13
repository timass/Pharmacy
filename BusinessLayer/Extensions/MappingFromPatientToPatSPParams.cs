using DataLayer;
using System;

namespace BusinessLayer.Extensions
{
    public static class MappingFromPatientToPatSPParams
    {
        public static PatientSPParams MappFromPatientToPatSPParams(this Patient pat)
        {
            return new PatientSPParams
            {
                PatientId = Guid.Parse(nameof(pat.PatientId)),
                Name = nameof(pat.Name),
                LastName = nameof(pat.LastName),
                PharmacyName = nameof(pat.PharmacyName)
            };
        }        
    }
}
