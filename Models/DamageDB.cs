using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Models
{
    internal class DamageDB
    {
        private readonly string _host = "192.168.54.170";
        private readonly string _database = "BdIncidentTest";
        private readonly string _user = "sa";
        private readonly string _password = "f4d#he78!";
        private readonly string _connectionString;
        private readonly string _table = "Damages";

        public DamageDB() 
        {
            this._connectionString= "Data Source=" + this._host + ";" + "Initial Catalog=" + this._database + ";" + "User=" + this._user + ";" + "Password=" + this._password + "";
        }

        public List<Damage> Get()
        {
            List<Damage> result = new List<Damage>();
            string query = "SELECT * FROM " + this._table;

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); 

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    int DamagesId = reader.GetInt32(0);
                    string Description = reader.GetString(1);

                    Damage damage = new Damage(DamagesId, Description);
                    result.Add(damage);
                }

                reader.Close();
                connection.Close();
            }
       
            return result;
        }

        public void Create(Damage damage) {
            string query = "INSERT INTO " + this._table + " VALUES (@description)";


            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
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
        }

        public void Update(Damage damage, int damageId) {
            string query = "UPDATE "+this._table+ " SET Description=@description WHERE DamagesId=@id";

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
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
        }

        public void Delete(int damageId) {
            string query = "DELETE FROM " + this._table + " WHERE DamagesId=@id";

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
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
}
