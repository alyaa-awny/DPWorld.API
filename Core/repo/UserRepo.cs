using Core.Entities;
using Core.interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repo
{
    
    public class UserRepo:IUserRepo
    {
        private readonly ITokenProvider _tokenProvider;
        public UserRepo(ITokenProvider tokenPRovider)
        {
                _tokenProvider= tokenPRovider;
        }

        public string? login(string username, string password)
        {
          var res = User.LoginUser(username, password);
            if (res is null) { return null; }
            return _tokenProvider.creatToken(res);
        }

        public string register(User user)
        {
    
            User.RegisterUser(user);
            
            return _tokenProvider.creatToken(user);
        }
    }
}
