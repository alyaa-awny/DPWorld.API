using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        private static List<User> _users = new List<User>();
        public string Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }   
        public string Password { get; set; }

        public static void RegisterUser(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            _users.Add(user);
        }

        public static User? LoginUser(string username , string password)
        {
           var res = _users.FirstOrDefault(user => user.Name == username && user.Password == password);
            if(res is null) { return res; }

            return res;
            
        
        }
    }
}
