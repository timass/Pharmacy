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
                PharmacyId = ph.PharmacyId,
                PhName = ph.PhName,
                StateCode = ph.StateCode,
                Address = ph.Address,
                ContactEmail = ph.ContactEmail,
                ContactPhone = ph.ContactPhone
            };
        }

        public static PharmacyDomain ToPharmacyDomain(this PharmacySPResult phRes)
        {
            return new PharmacyDomain
            {
                PharmacyId = phRes.PharmacyId,
                PhName = phRes.PhName,
                StateCode = phRes.StateCode,
                Address = phRes.Address,
                ContactEmail = phRes.ContactEmail,
                ContactPhone = phRes.ContactPhone,
            };
        }
    }
}
