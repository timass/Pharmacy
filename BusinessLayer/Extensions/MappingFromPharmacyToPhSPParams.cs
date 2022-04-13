using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class MappingFromPharmacyToPhSPParams
    {
        public static PharmacySPParams MappFromPharmacyToPhSPParams(this Pharmacy ph)
        {
            return new PharmacySPParams
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
