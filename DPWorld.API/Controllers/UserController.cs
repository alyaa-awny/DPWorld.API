using Core.Entities;
using Core.interfaces;
using DPWorld.API.DTO;
using DPWorld.API.Extensions;
using DPWorld.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DPWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IFinancialRepo _financialRepo;
        public UserController(IUserService userService, ILogger<UserController> logger, IFinancialRepo financialRepo)
        {
            _logger = logger;
            _userService = userService;   
            _financialRepo = financialRepo;
        }
        [HttpPost]
        [Authorize]
        [Route("GetFinancialData")]
        public  ActionResult GetFile(IFormFile file)
        {
            StreamReader st = new StreamReader(file.OpenReadStream(), Encoding.UTF8);

            var newReseit = st.CsvToJsonConverter();

            return Ok(newReseit);
        }
        [HttpPost]
        [Route("login")]
        public ActionResult<UserReponseDto> Login( LoginDto login)
        {
            var res = _userService.Login(login);
            if(res is null)
            {
                return BadRequest("You Have entered invalid info");
            }
            return Ok(new UserReponseDto
            {
                Username = login.Username,
                Token = res

            });
        }

        [HttpPost]
        [Route("register")]
        public ActionResult<UserReponseDto> Register(RegisterDto register)
        {
    
            var res = _userService.RegisterService(register);
            if (res is null)
            {
                return BadRequest("You Have entered invalid info");
            }
            return Ok(new UserReponseDto
            {
                Username = register.Name,
                Token = res

            });
        }
    }
}
