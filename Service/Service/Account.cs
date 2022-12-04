using Service.Enum;
using Service.Helpers.Constans;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class Account : IAccount
    {
        public string Login(string email, string password, int role)
        {
            if (email==AccountContans.Email && password == AccountContans.Password)
            {
                if (CheckRole(role))
                {
                    return AccountContans.SuperAdminValidEntrance;
                }
                else
                {
                    return AccountContans.SuperAdminCredentialsInvalid;
                }
            }
            else
            {
                return AccountContans.CredentialsInvalid;
            }
        }

        private bool CheckRole(int role)
        {
            switch (role)
            {
                case (int)Roles.SuperAdmin:
                    return true;
                default:
                    return false;
            }
        }
    }
}
