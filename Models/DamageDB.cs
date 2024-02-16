using System.Data.SqlClient;

namespace ConsoleApp1.Models
{
    internal class DamageDb
    {
        private const string Host = "192.168.54.170";
        private const string Database = "BdIncidentTest";
        private const string User = "sa";
        private const string Password = "f4d#he78!";
        private const string ConnectionString = "Data Source=" + Host + ";" + "Initial Catalog=" + Database + ";" + "User=" + User + ";" + "Password=" + Password + "";
        private const string Table = "Damages";

        public List<Damage> Get()
        {
            var result = new List<Damage>();
            const string query = "SELECT * FROM " + Table;

            using var connection = new SqlConnection(ConnectionString);
            var command = new SqlCommand(query, connection); 

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read()) {
                var damagesId = reader.GetInt32(0);
                var description = reader.GetString(1);

                var damage = new Damage(damagesId, description);
                result.Add(damage);
            }

            reader.Close();
            connection.Close();

            return result;
        }

        public void Create(Damage damage) {
            const string query = "INSERT INTO " + Table + " VALUES (@description)";


            using var connection = new SqlConnection(ConnectionString);
            try
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@description", damage.Description);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch 
            {
                connection.Close();
            }
        }

        public void Update(Damage damage, int damageId) {
            const string query = "UPDATE " + Table + " SET Description=@description WHERE DamagesId=@id";

            using var connection = new SqlConnection(ConnectionString);
            try
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@description", damage.Description);
                command.Parameters.AddWithValue("@id", damageId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        public void Delete(int damageId) {
            const string query = "DELETE FROM " + Table + " WHERE DamagesId=@id";

            using var connection = new SqlConnection(ConnectionString);
            try
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", damageId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }
    }
}
