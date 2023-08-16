using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.interfaces
{
    public interface IUserRepo
    {
        public string login (string username, string password);
        public  string register (User user);
    }
}
