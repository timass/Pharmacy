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
                PatientId = Guid.Parse(nameof(pat.PatientId)),
                Name = nameof(pat.Name),
                LastName = nameof(pat.LastName),
                PharmacyName = nameof(pat.PharmacyName)
            };
        }

        public static PatientDomain ToPatientDomain(this PatientViewModel pat)
        {
            return new PatientDomain
            {
                PatientId = Guid.Parse(nameof(pat.PatientId)),
                Name = nameof(pat.Name),
                LastName = nameof(pat.LastName),
                PharmacyName = nameof(pat.PharmacyName)

            };
        }
    }    
}
