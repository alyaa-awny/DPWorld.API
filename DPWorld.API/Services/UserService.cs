using Core.Entities;
using Core.interfaces;
using DPWorld.API.DTO;
using DPWorld.API.Services.Interfaces;
using Microsoft.Win32;

namespace DPWorld.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo= userRepo;
        }

        public string? Login(LoginDto login)
        {
            var res = _userRepo.login(login.Username , login.Password);
            return res;
        }

        public string? RegisterService(RegisterDto regist)
        {
            var newUser = new User
            {
                Name = regist.Name,
                Email = regist.Email,
                Password = regist.Password,
            };

            var res = _userRepo.register(newUser);
            return res;
        }
    }
}
