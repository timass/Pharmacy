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
                throw new Exception(ex.Message);                
              } 
            }

        public async Task<List<PharmacySPResult>> GetFiltered(PharmacySPParams pharm)
        {
            List<PharmacySPResult> list = new List<PharmacySPResult>();
            string sqlExpression = "SPGetFilteredPharmacies";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.AddWithValue("@PharmacyId", pharm.PharmacyId);                                      
                    adapter.SelectCommand.Parameters.AddWithValue("@PhName", pharm.PhName);                   
                    adapter.SelectCommand.Parameters.AddWithValue("@StateCode", pharm.StateCode);                    
                    adapter.SelectCommand.Parameters.AddWithValue("@Address", pharm.Address);                   
                    adapter.SelectCommand.Parameters.AddWithValue("@ContactEmail", pharm.ContactEmail);                   
                    adapter.SelectCommand.Parameters.AddWithValue("@ContactPhone", pharm.ContactPhone);
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
                throw new Exception(ex.Message);
            }
        }

        public async void Create(PharmacySPParams pharm)
        {            
            string sqlExpression = "SPCreatePharmacy";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = sqlExpression,
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };                   
                    command.Parameters.AddWithValue("@PharmacyId", pharm.PharmacyId);                    
                    command.Parameters.AddWithValue("@PhName", pharm.PhName);                   
                    command.Parameters.AddWithValue("@StateCode", pharm.StateCode);                    
                    command.Parameters.AddWithValue("@Address", pharm.Address);                    
                    command.Parameters.AddWithValue("@ContactEmail", pharm.ContactEmail);                   
                    command.Parameters.AddWithValue("@ContactPhone", pharm.ContactPhone);                   
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();                       
                }                              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async void Update(PharmacySPParams pharm)
            {
            string sqlExpression = "SPUpdatePharmacy";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = sqlExpression,
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@PharmacyId", pharm.PharmacyId);
                    command.Parameters.AddWithValue("@PhName", pharm.PhName);
                    command.Parameters.AddWithValue("@StateCode", pharm.StateCode);
                    command.Parameters.AddWithValue("@Address", pharm.Address);
                    command.Parameters.AddWithValue("@ContactEmail", pharm.ContactEmail);
                    command.Parameters.AddWithValue("@ContactPhone", pharm.ContactPhone);
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(string condition)
        {
            throw new NotImplementedException();
        }
        
    }
}
