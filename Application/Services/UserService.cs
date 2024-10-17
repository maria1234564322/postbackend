using Application.IServices;
using DataAccess.Entities;
using DataAccess.Repostories.Users;

namespace Application.Services
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

            var userLocation = new DbLocation()
            {
                PostalCode = dto.PostalCode,
                State = dto.Region,
                City = dto.City,
                Street = dto.Street,
                Apartment = dto.House
            };

            var user = new DbUser
            {
                Email = dto.Email,
                Password = dto.Password,
                Surname = dto.Surname,
                Name = dto.Name,
                MiddleName = dto.MiddleName,
                Phone = dto.Phone,
                UserLocation = userLocation
            };

            _repository.Create(user);
        }

        public DbUser FindUserByEmailAndPassword(string email, string password)
        {
            return _repository.FindByEmailAndPassword(email, password);
        }
    }
}



