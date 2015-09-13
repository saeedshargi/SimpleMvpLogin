using System.Data.Entity;
using System.Linq;

namespace SimpleMvpLogin.Model
{
    public class LoginModel : ILoginModel
    {
        private readonly IUnitOfWork _uow;
        private readonly IDbSet<Membership> _memberships;

        public LoginModel(IUnitOfWork uow)
        {
            _uow = uow;
            _memberships = uow.Set<Membership>();
        }

        public bool IsLoginValid(string userName, string password)
        {
            return _memberships.Any(c => c.UserName == userName && c.Password == password);
        }
    }
}