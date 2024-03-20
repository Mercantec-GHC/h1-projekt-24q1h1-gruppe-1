using Domain_Models;
using Npgsql;

namespace BlazorApp.Services
{
    public class DatabaseService
    {
        public string connectionString;

        public DatabaseService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Headset> GetAllHeadsets()
        {
            List<Headset> allProducts = new List<Headset>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql =
                    "SELECT Brand, Model, Color, FrequencyRange, Microphone, TypeOfConnection, NoiseCancellation, ClosedOrOpen, ItemCondition, Price, ImageUrl, type FROM Headsets";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader["type"].ToString();
                            if (type == "WiredHeadphones")
                            {
                                allProducts.Add(new WiredHeadphones(
                                    reader["Brand"].ToString(),
                                    reader["Model"].ToString(),
                                    reader["Color"].ToString(),
                                    reader["FrequencyRange"].ToString(),
                                    Convert.ToBoolean(reader["Microphone"]),
                                    reader["TypeOfConnection"].ToString(),
                                    Convert.ToBoolean(reader["NoiseCancellation"]),
                                    reader["ClosedOrOpen"].ToString(),
                                    reader["ItemCondition"].ToString(),
                                    Convert.ToInt32(reader["Price"]),
                                    reader["ImageUrl"].ToString())
                                );
                            }
                            else if (type == "BluetoothHeadphones")
                            {
                                allProducts.Add(new BluetoothHeadphones(
                                    reader["Brand"].ToString(),
                                    reader["Model"].ToString(),
                                    reader["Color"].ToString(),
                                    reader["FrequencyRange"].ToString(),
                                    Convert.ToBoolean(reader["Microphone"]),
                                    reader["TypeOfConnection"].ToString(),
                                    Convert.ToBoolean(reader["NoiseCancellation"]),
                                    reader["ClosedOrOpen"].ToString(),
                                    reader["ItemCondition"].ToString(),
                                    Convert.ToInt32(reader["Price"]),
                                    reader["ImageUrl"].ToString())
                                );
                            }
                        }
                        return allProducts;
                    }
                }
            }
        }
    }
}