using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class UserDB : IUserDB
    {

        private string connectionString = null;

        public UserDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["remoteDB"].ConnectionString;
        }

        public float getAmountByUsername(string username)
        {
            
            float result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "select Amount from [User] where Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
 

                            if (dr["Amount"] != DBNull.Value)
                                 result =  float.Parse(dr["Amount"].ToString());
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public float getAmountById(int id)
        {
            float result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "select Amount from [User] where Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {


                            if (dr["Amount"] != DBNull.Value)
                                result = float.Parse(dr["Amount"].ToString());
                        }


                        
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public void UpdateAmountByUsername(string username, float amount)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "update [User] set Amount = @Amount where Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Username", username);

                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateAmountByID(int id, float amount)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "update [User] set Amount = @Amount where Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
