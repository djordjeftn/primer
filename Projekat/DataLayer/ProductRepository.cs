using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductRepository
    {
        public List<Products> GetAllProducts()
        {
            List<Products> lista = new List<Products>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Products";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Products b = new Products();
                    b.Id = sqlDataReader.GetInt32(0);
                    b.Name = sqlDataReader.GetString(1);
                    b.Description = sqlDataReader.GetString(2);
                    b.ExpiryDate = sqlDataReader.GetDateTime(3);

                    lista.Add(b);
                }
            }

            return lista;
        }
        public int InsertProducts(Products b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Products VALUES ('{0}', '{1}', '{2}')",
                        b.Name, b.Description, b.ExpiryDate);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
