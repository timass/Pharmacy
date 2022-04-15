using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.Extensions;

namespace BusinessLayer.Services
{
    public class PharmacyService
    {
        private PharmacyRepository Repos = new PharmacyRepository();
       
        public async Task<List<PharmacyDomain>> GetAllPharmacy()
        {
            List<PharmacySPResult> listSPResult = await Repos.GetAllAsync();
            List<PharmacyDomain> listDomain = listSPResult.Select(p => p.ToPharmacyDomain()).ToList();
            return listDomain;
        }
    }   
}
