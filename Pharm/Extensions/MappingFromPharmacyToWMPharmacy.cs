using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Extensions
{
    public static class MappingFromPharmacyToWMPharmacy
    {
        public static WMPharmacy MappFromPharmacyToWMPharmacy(this Pharmacy wmPh)
        {
            return new WMPharmacy
            {
                PharmacyId = Guid.Parse(nameof(wmPh.PharmacyId)),
                PhName = nameof(wmPh.PhName),
                StateCode = nameof(wmPh.StateCode),
                Address = nameof(wmPh.Address),
                ContactEmail = nameof(wmPh.ContactEmail),
                ContactPhone = nameof(wmPh.ContactPhone)
            };
        }
    }
}
