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
                PatientId = pat.PatientId,
                Name = pat.Name,
                LastName = pat.LastName,
                PharmacyName = pat.PharmacyName
            };
        }
        public static PatientDomain ToPatientDomain(this PatientSPResult patRes)
        {
            return new PatientDomain
            {
                PatientId = patRes.PatientId,
                Name = patRes.Name,
                LastName = patRes.LastName,
                PharmacyName = patRes.PharmacyName
            };
        }
    }
}
