using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRepositoryPharmacy
    {
        Task<List<PharmacySPResult>> GetAllAsync(PharmacySPParams ph);


        IEnumerable<PharmacySPParams> GetForCondition(string condition);


        void Create(string type, string data);


        void Update(string condition, string[] fieldName, object[] fieldValues);


        void Delete(string condition);
    }
}
