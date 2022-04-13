using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class MappingFromPatSPResultToPatient
    {
        public static Patient MappFromPatSPResultToPatient(this PatientSPResult patRes)
        {
            return new Patient
            {
                PatientId = Guid.Parse(nameof(patRes.PatientId)),
                Name = nameof(patRes.Name),
                LastName = nameof(patRes.LastName),
                PharmacyName = nameof(patRes.PharmacyName)
            };            
        }
    }    
}
