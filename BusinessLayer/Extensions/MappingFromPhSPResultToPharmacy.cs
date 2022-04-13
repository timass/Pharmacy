using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class MappingFromPhSPResultToPharmacy
    {
        public static Pharmacy MappFromPhSPResultToPharmacy(this PharmacySPResult phRes)
        {
            return new Pharmacy
            {
                PharmacyId = Guid.Parse(nameof(phRes.PharmacyId)),
                PhName = nameof(phRes.PhName),
                StateCode = nameof(phRes.StateCode),
                Address = nameof(phRes.Address),
                ContactEmail = nameof(phRes.ContactEmail),
                ContactPhone = nameof(phRes.ContactPhone),
            };
        }
    }
}
