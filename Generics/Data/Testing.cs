using System;
using System.Data.SqlClient;
using Entities.Animlas;

namespace Data
{
    public class Testing
    {
        private static readonly string ConnectionString = "Data Source=.; Initial Catalog=testing ;Integrated Security=true";

        public static SqlDataReader TestSql()
        {
            var connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM animals", connection);
                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var animal = new Dog
                    {
                        Race = dataReader.GetString(0),
                        Name = dataReader.GetString(1),
                        Age = dataReader.GetInt32(2),
                        ManagerId = Guid.Parse(dataReader.GetString(3)),
                        Id = Guid.Parse(dataReader.GetString(4))
                    };
                }

                return dataReader;
            }
            catch (SqlException)
            {
                throw;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
