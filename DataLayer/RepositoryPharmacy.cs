﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;



namespace DataLayer
{
    public class RepositoryPharmacy
    {

        static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Pharmacy; Integrated Security=True; TrustServerCertificate=True";


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
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    
                    foreach (DataTable dt in ds.Tables)
                    {
                        int i = dt.Rows.Count;
                        DataRow obj = dt.Rows[0];
                        for(int k = 0; k< dt.Rows.Count; k++)
                        {
                          //  object obj2 = dt.Rows[k];                           
                            PharmacySPResult phar = new PharmacySPResult(
                                dt.Rows[k].Field<Guid>(nameof(ph.PharmaciesId)),                         
                                dt.Rows[k].Field<String>(nameof(ph.PhName)),
                                dt.Rows[k].Field<String>(nameof(ph.StateCode)),
                                dt.Rows[k].Field<String>(nameof(ph.Address)),
                                dt.Rows[k].Field<String>(nameof(ph.ContactEmail)),
                                dt.Rows[k].Field<String>(nameof(ph.ContactPhone))
                            );
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
