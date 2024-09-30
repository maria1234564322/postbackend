using DataAccess;
using System;

namespace Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void RegisterUser(UserDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Email) || !dto.Email.Contains("@"))
            {
                throw new ArgumentException("Invalid email address.");
            }

            if (dto.Password != dto.ConfirmPassword)
            {
                throw new ArgumentException("Passwords do not match.");
            }

            var user = new User
            {
                Email = dto.Email,
                Password = dto.Password,
                Surname = dto.Surname,
                Name = dto.Name,
                MiddleName = dto.MiddleName,
                Phone = dto.Phone,
                PostalCode = dto.PostalCode,
                Region = dto.Region,
                District = dto.District,
                City = dto.City,
                Street = dto.Street,
                House = dto.House
            };

            _repository.Create(user);
        }

        public User FindUserByEmailAndPassword(string email, string password)
        {
            return _repository.FindByEmailAndPassword(email, password);
        }
    }
}



