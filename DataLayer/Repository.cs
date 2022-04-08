using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    abstract class Repository
    {
        abstract public List<PharmacySPResult> GetAll(PharmacySPParams phParams, PharmacySPResult phResult);
      

        public IEnumerable<PharmacySPParams> GetForCondition(string condition)
        {
            throw new NotImplementedException();
        }

        public void Create(string type, string data)
        {
            throw new NotImplementedException();
        }

        public void Update(string condition, string[] fieldName, object[] fieldValues)
        {
            throw new NotImplementedException();
        }

        public void Delete(string condition)
        {
            throw new NotImplementedException();
        }
    }
}
