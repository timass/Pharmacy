namespace DataLayer
{

    public class UnitOfWork : IUnitOfWork
    {
       

        private RepositoryPharmacy PharmacyRepository;       
        private RepositoryPatient  PatientRepository;
        public RepositoryPharmacy pharmacyRepository
        {
            get
            {
                if (this.PharmacyRepository == null)
                {
                    this.PharmacyRepository = new RepositoryPharmacy();
                }
                
                return PharmacyRepository;
            }

        }

        public RepositoryPatient patientRepository
        {
            get
            {

                if (this.PatientRepository == null)
                {
                    this.PatientRepository = new RepositoryPatient();
                }
                return PatientRepository;
            }
        }       
    }      
}
               
    

