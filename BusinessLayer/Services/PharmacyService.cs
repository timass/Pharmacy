using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.Extensions;

namespace BusinessLayer.Services
{
    public class PharmacyService
    {
        private readonly PharmacyRepository Repos;

        public PharmacyService()
        {
            Repos = new PharmacyRepository();
        }
        
        public async Task<List<PharmacyDomain>> GetAllPharmacy()
        {
            List<PharmacySPResult> listSPResult = await Repos.GetAllAsync();
            List<PharmacyDomain> listDomain = listSPResult.Select(p => p.ToPharmacyDomain()).ToList();
            return listDomain;
        }
        public async Task<List<PharmacyDomain>> GetFiltered(PharmacyDomain pharmacy)
        {
            List<PharmacySPResult> listSPResult = await Repos.GetFiltered(pharmacy.ToPharmacySPParams());
            List<PharmacyDomain> listDomain = listSPResult.Select(p => p.ToPharmacyDomain()).ToList();
            return listDomain;
        }

        public void Create(PharmacyDomain pharmacy)
        {
            Repos.Create(pharmacy.ToPharmacySPParams());                       
        }

        public void Update(PharmacyDomain pharmacy)
        {
            Repos.Update(pharmacy.ToPharmacySPParams());
        }
    }   
}
