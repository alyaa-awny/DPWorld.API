using DPWorld.API.DTO;

namespace DPWorld.API.Services.Interfaces
{
    public interface IUserService
    {
        public string? RegisterService(RegisterDto regist);
        public string? Login(LoginDto login);

    }
}
