using System;
using System.Data;

namespace DataLayer
{ 
    public class Pharmacy
    {
        public Pharmacy()
        {
           
        }
        public Pharmacy(PharmacySPResult phResult)
        {
            PharmacyId = phResult.PharmaciesId;
            Name = phResult.PhName;
            StateCode = phResult.StateCode;
            Address = phResult.Address;
            ContactEmail = phResult.ContactEmail;
            ContactPhone = phResult.ContactPhone;
        }
        public Guid PharmacyId { get; set; }

        public string Name { get; set; }

        public string StateCode { get; set; }

        public string Address { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

        //public void Reader(PharmacySPParams phParams, PharmacySPResult phResult)
        //{
        //    PharmacyId = phParams.PharmacyId;
        //    Name = phParams.Name;
        //    StateCode = phParams.StateCode;
        //    Address = phParams.Address;
        //    ContactEmail = phParams.ContactEmail;
        //    ContactPhone = phParams.ContactPhone;
        //}

    }
}
