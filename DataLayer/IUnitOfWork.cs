using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUnitOfWork
    {
        RepositoryPharmacy pharmacyRepository { get; }
        RepositoryPatient patientRepository { get; }
    }
}
