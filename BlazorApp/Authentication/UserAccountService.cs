using Npgsql;

// Managing user accounts by retrieving Userdata from DB

namespace BlazorApp.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users; //Create a list of users

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
                        while (reader.Read()) // Iterates through the results and adding user account objects to users_ list
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

        public UserAccount? GetByUserName(string userName) //Retrieve user account by username 
        {
            return _users.FirstOrDefault(x => x.UserName == userName); // search for specific username in _users-list or return null
        }
    }
}
