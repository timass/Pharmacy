using System;
using System.Data;

namespace BusinessLayer
{ 
    public class PharmacyDomain
    {     
        public Guid? PharmacyId { get; set; }

        public string PhName { get; set; }

        public string StateCode { get; set; }

        public string Address { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }   
    }
}
