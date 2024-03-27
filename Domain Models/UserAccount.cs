using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    public abstract class UserAccount
    {

        public uint Id { get; set; }
        private static uint lastId = 0;

        public string url { get; set; }

        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int yearOfBirth { get; set; }
        public string email { get; set; }
        public int phoneNumber { get; set; }
        public string userPassword { get; set; }

        public string address { get; set; }

        public string country { get; set; }

        public string city { get; set; }

        public string status { get; set; }


        public UserAccount(string userName, string firstName, string lastName, int yearOfBirth, string email, int phoneNumber, string userPassword, string address, string country, string city, string status)
        {
            this.url = $"createuser/{lastId}";
            Id = lastId++;
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.userPassword = userPassword;
            this.address = address;
            this.country = country;
            this.city = city;
            this.status = status;
            
        }
    }

    public abstract class User : UserAccount
    {
        public User(string userName,string firstName, string lastName,int yearOfBirth, string email,
        int phoneNumber, string userPassword, string address, string country, string city, string status)
            : base (userName, firstName, lastName, yearOfBirth, email, phoneNumber, userPassword, address, country, city, status)
        {

        }
    }
}
