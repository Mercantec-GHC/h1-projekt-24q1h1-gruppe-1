using Npgsql;

namespace BlazorApp.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            string connectionString = "Host=ep-blue-fire-a2nnh5p7.eu-central-1.aws.neon.tech;Username=sonaredb_owner;Password=8LlUVraRtDs9;Database=sonaredb;SSL Mode=Require";
            _users = new List<UserAccount>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand("SELECT username, userpassword FROM useraccount", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _users.Add(new UserAccount
                            {
                                UserName = reader.GetString(0),
                                Password = reader.GetString(1)
                            });
                        }
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
