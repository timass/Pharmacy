using System;

namespace DataLayer
{ 
    public class Pharmacy
    {
        public Guid PharmacyId { get; set; }

        public string Name { get; set; }

        public string StateCode { get; set; }

        public string Address { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

    }
}
