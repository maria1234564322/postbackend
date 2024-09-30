using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }

        // Конструктор за замовчуванням
        public User() { }

        // Конструктор з параметрами
        public User(string email, string password, string confirmPassword, string surname, string name, string middleName, string phone, string postalCode, string region, string district, string city, string street, string house)
        {
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            Phone = phone;
            PostalCode = postalCode;
            Region = region;
            District = district;
            City = city;
            Street = street;
            House = house;
        }
    }

}
