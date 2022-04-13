using BusinessLayer;
using System;

namespace Pharm.Extensions
{
    public static class MappingFromWMPharmacyToPharmacy
    {
        public static Pharmacy MappFromWMPharmacyToPharmacy(this WMPharmacy ph)

        {
            return new Pharmacy
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
