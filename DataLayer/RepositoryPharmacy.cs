using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;



namespace DataLayer
{
    public class RepositoryPharmacy
    {
        
            static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Pharm;Trusted_Connection=True;";


            public List<PharmacySPResult> GetAll(PharmacySPParams ph)
            {

                  
                List<PharmacySPResult> list = new List<PharmacySPResult>();
                string sqlExpression = "SPGetAllPharmacies";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable tab = ds.Tables["Pharmacies"];
                    foreach (DataRow row in tab.Rows)
                    {
                        list.Add(new PharmacySPResult
                        {
                            PharmacyId = row.Field<Guid>(nameof(ph.PharmacyId)),
                            Name = row.Field<String>(nameof(ph.Name)),
                            StateCode = row.Field<String>(nameof(ph.StateCode)),
                            Address = row.Field<String>(nameof(ph.Address)),
                            ContactEmail = row.Field<String>(nameof(ph.ContactEmail)),
                            ContactPhone = row.Field<String>(nameof(ph.ContactPhone))
                        });
                    }

                }
                return list;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return list;
            }    
           
               
            }

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
