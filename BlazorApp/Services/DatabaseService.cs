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

                string sql = "SELECT id, Brand, Model, Color, FrequencyRange, Microphone, TypeOfConnection, NoiseCancellation, ClosedOrOpen, ItemCondition, Price, ImageUrl, type, Description FROM Headsets order by id";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader.IsDBNull(reader.GetOrdinal("type")) ? null : reader["type"].ToString();
                            if (type == "WiredHeadphones")
                            {
                                allProducts.Add(new WiredHeadphones(
                                    reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : Convert.ToInt32(reader["id"]),
                                    reader.IsDBNull(reader.GetOrdinal("Brand")) ? null : reader["Brand"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Model")) ? null : reader["Model"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Color")) ? null : reader["Color"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("FrequencyRange")) ? null : reader["FrequencyRange"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Microphone")) ? false : Convert.ToBoolean(reader["Microphone"]),
                                    reader.IsDBNull(reader.GetOrdinal("TypeOfConnection")) ? null : reader["TypeOfConnection"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("NoiseCancellation")) ? false : Convert.ToBoolean(reader["NoiseCancellation"]),
                                    reader.IsDBNull(reader.GetOrdinal("ClosedOrOpen")) ? null : reader["ClosedOrOpen"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("ItemCondition")) ? null : reader["ItemCondition"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : Convert.ToInt32(reader["Price"]),
                                    reader.IsDBNull(reader.GetOrdinal("ImageUrl")) ? null : reader["ImageUrl"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader["Description"].ToString())
                                );
                            }
                            else if (type == "BluetoothHeadphones")
                            {
                                allProducts.Add(new BluetoothHeadphones(
                                    reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : Convert.ToInt32(reader["id"]),
                                    reader.IsDBNull(reader.GetOrdinal("Brand")) ? null : reader["Brand"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Model")) ? null : reader["Model"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Color")) ? null : reader["Color"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("FrequencyRange")) ? null : reader["FrequencyRange"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Microphone")) ? false : Convert.ToBoolean(reader["Microphone"]),
                                    reader.IsDBNull(reader.GetOrdinal("TypeOfConnection")) ? null : reader["TypeOfConnection"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("NoiseCancellation")) ? false : Convert.ToBoolean(reader["NoiseCancellation"]),
                                    reader.IsDBNull(reader.GetOrdinal("ClosedOrOpen")) ? null : reader["ClosedOrOpen"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("ItemCondition")) ? null : reader["ItemCondition"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : Convert.ToInt32(reader["Price"]),
                                    reader.IsDBNull(reader.GetOrdinal("ImageUrl")) ? null : reader["ImageUrl"].ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader["Description"].ToString())
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