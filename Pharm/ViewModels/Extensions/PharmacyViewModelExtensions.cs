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
                PharmacyId = ph.PharmacyId,
                PhName = ph.PhName,
                StateCode = ph.StateCode,
                Address = ph.Address,
                ContactEmail = ph.ContactEmail,
                ContactPhone = ph.ContactPhone
            };
        }
        public static PharmacyDomain ToPharmacyDomain(this PharmacyViewModel ph)

        {
            return new PharmacyDomain
            {
                PharmacyId = ph.PharmacyId, 
                PhName = ph.PhName,
                StateCode = ph.StateCode,
                Address = ph.Address,
                ContactEmail = ph.ContactEmail,
                ContactPhone = ph.ContactPhone
            };            
        }
      
    }
}
