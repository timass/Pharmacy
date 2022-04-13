using BusinessLayer;

using System;

namespace Pharm.Extensions
{
    public static class PatientViewModelExtensions
    {
        public static PatientViewModel ToPatientViewModel(this PatientDomain pat)
        {
            return new PatientViewModel
            {
                PatientId = pat.PatientId,
                Name = pat.Name,
                LastName = pat.LastName,
                PharmacyName = pat.PharmacyName
            };
        }

        public static PatientDomain ToPatientDomain(this PatientViewModel pat)
        {
            return new PatientDomain
            {
                PatientId = pat.PatientId,
                Name = pat.Name,
                LastName = pat.LastName,
                PharmacyName = pat.PharmacyName

            };
        }
    }    
}
