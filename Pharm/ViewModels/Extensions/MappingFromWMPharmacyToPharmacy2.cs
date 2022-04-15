using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharm.Extensions
{
    public static class MappingFromWMPharmacyToPharmacy2
    {
        public static Pharmacy MappFromWMPharmacyToPharmacy2(this Pharmacy ph, WMPharmacy wmPh)
        {
            ph.PharmacyId = Guid.Parse(nameof(wmPh.PharmacyId));
            ph.PhName = nameof(wmPh.PhName);
            ph.StateCode = nameof(wmPh.StateCode);
            ph.Address = nameof(wmPh.Address);
            ph.ContactEmail = nameof(wmPh.ContactEmail);
            ph.ContactPhone = nameof(wmPh.ContactPhone);
            return ph;
        }
    }
}