using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PharmacyRepository
    {


        static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Pharmacy; Integrated Security=True; TrustServerCertificate=True";


            public async Task<List<PharmacySPResult>> GetAllAsync()
            {                  
                List<PharmacySPResult> list = new List<PharmacySPResult>();
                string sqlExpression = "SPGetPharmacies"; 
              try
              {                
               using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow item in dt.Rows)
                        { 
                            PharmacySPResult phar = new PharmacySPResult
                            {
                               PharmacyId = item.Field<Guid>(nameof(PharmacySPParams.PharmacyId)),
                               PhName = item.Field<String>(nameof(PharmacySPParams.PhName)),
                               StateCode = item.Field<String>(nameof(PharmacySPParams.StateCode)),
                               Address = item.Field<String>(nameof(PharmacySPParams.Address)),
                               ContactEmail = item.Field<String>(nameof(PharmacySPParams.ContactEmail)),
                               ContactPhone = item.Field<String>(nameof(PharmacySPParams.ContactPhone))
                            };
                            list.Add(phar);
                        }
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
