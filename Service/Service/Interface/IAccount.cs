using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interface
{
    public interface IAccount
    {
        public string Login(string email, string password, int role);
    }
}
