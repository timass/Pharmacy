using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class PharmacyDomainExtensions
    {
        public static PharmacySPParams ToPharmacySPParams(this PharmacyDomain ph)
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

        public static PharmacyDomain ToPharmacyDomain(this PharmacySPResult phRes)
        {
            return new PharmacyDomain
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
