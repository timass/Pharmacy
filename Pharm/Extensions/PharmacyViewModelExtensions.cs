using BusinessLayer;
using System;

namespace Pharm.Extensions
{
    public static class PharmacyViewModelExtensions
    {
        public static PharmacyViewModel ToPharmacyViewModel(this PharmacyDomain ph)
        {
            return new PharmacyViewModel
            {
                PharmacyId = Guid.Parse(nameof(ph.PharmacyId)),
                PhName = nameof(ph.PhName),
                StateCode = nameof(ph.StateCode),
                Address = nameof(ph.Address),
                ContactEmail = nameof(ph.ContactEmail),
                ContactPhone = nameof(ph.ContactPhone)
            };
        }

        public static PharmacyDomain ToPharmacyDomain(this PharmacyViewModel ph)

        {
            return new PharmacyDomain
            {
                PharmacyId = Guid.Parse(nameof(ph.PharmacyId)),
                PhName = nameof(ph.PhName),
                StateCode = nameof(ph.StateCode),
                Address = nameof(ph.Address),
                ContactEmail = nameof(ph.ContactEmail),
                ContactPhone = nameof(ph.ContactPhone)
            };            
        }
      
    }
}
