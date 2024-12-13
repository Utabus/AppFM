using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        public UserDAO DAO = new UserDAO();

        public Account Login(string username, string password)
        {
            return DAO.Login(username, password);
        }
    }
}
