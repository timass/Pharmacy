using System;

namespace DataLayer
{
    public class PharmacySPResult
    {
        public PharmacySPResult(Guid pharmacyId, string phName, string stateCode, string address, string contactEmail, string contactPhone)
        {
            PharmaciesId = pharmacyId;
            PhName = phName;
            StateCode = stateCode;
            Address = address;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
        }

        public Guid PharmaciesId;

        public string PhName;

        public string StateCode;

        public string Address;

        public string ContactEmail;

        public string ContactPhone;
    }
}
