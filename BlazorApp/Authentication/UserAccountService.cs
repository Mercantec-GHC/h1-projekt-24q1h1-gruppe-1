using Microsoft.AspNetCore.Components;
using Npgsql;

namespace BlazorApp.Authentication
{
    public class UserAccountService
    {
        private string? username { get; set; }
        private string? userpassword { get; set; }
        //private string ErrorMessage { get; set; } = "";

        private List<UserAccount> _users;

        public UserAccountService()
        {
            string connectionString = "Host=ep-blue-fire-a2nnh5p7.eu-central-1.aws.neon.tech;Username=sonaredb_owner;Password=8LlUVraRtDs9;Database=sonaredb;SSL Mode=Require";

            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;

                cmd.CommandText = @"
                SELECT username, userpassword
                FROM useraccount
                WHERE username = @username AND userpassword = @userpassword";

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@userpassword", userpassword);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = reader.GetString(reader.GetOrdinal("username"));
                        string userpassword = reader.GetString(reader.GetOrdinal("userpassword"));

                        _users = new List<UserAccount>

                        {
                            new UserAccount{ UserName = username, Password = userpassword }
                        };
                    }
                }
            }
        }

        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
