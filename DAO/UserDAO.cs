using DTO;
using DAO.Extension;

namespace DAO
{
    public class UserDAO
    {
        private FmStyleDbContext _context = new FmStyleDbContext();

        public Account Login(string username, string password)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.UserName == username && x.Password == password.ToMD5());
            if (account != null)
            {

                return account;
            }
            return null;
        }

    }
}
