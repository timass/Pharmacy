using DataLayer;
using System;

namespace BusinessLayer.Extensions
{
    public static class PatientDomainExtensions
    {
        public static PatientSPParams ToPatientSPParams(this PatientDomain pat)
        {
            return new PatientSPParams
            {
                PatientId = Guid.Parse(nameof(pat.PatientId)),
                Name = nameof(pat.Name),
                LastName = nameof(pat.LastName),
                PharmacyName = nameof(pat.PharmacyName)
            };
        }
        public static PatientDomain ToPatientDomain(this PatientSPResult patRes)
        {
            return new PatientDomain
            {
                PatientId = Guid.Parse(nameof(patRes.PatientId)),
                Name = nameof(patRes.Name),
                LastName = nameof(patRes.LastName),
                PharmacyName = nameof(patRes.PharmacyName)
            };
        }
    }
}
