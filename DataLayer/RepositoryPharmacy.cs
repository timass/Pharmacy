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

            DataSet ds = new DataSet();
            
            
            
            DataTable pharm = ds.Tables["Pharmacies"];          
                List<PharmacySPResult> list = new List<PharmacySPResult>();
                string sqlExpression = "SPGetAllPharmacies";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                            list.Add(new PharmacySPResult
                            {
                               // PharmacyId = pharm.Field<Guid>(nameof(ph.PharmacyId)),
                                PharmacyId = (Guid)reader[nameof(ph.PharmacyId)],
                                Name = (String)reader[nameof(ph.Name)],
                                StateCode = (String)reader[nameof(ph.StateCode)],
                                Address = (String)reader[nameof(ph.Address)],
                                ContactEmail = (String)reader[nameof(ph.ContactEmail)],
                                ContactPhone = (String)reader[nameof(ph.ContactPhone)]
                            });
                               
                            }
                        }
                    }
                }
                return list;
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
