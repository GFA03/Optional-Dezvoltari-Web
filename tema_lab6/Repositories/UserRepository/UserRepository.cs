using tema_lab4.Data;
using tema_lab4.Repositories.GenericRepository;
using tema_lab4.Helpers.Extensions;
using tema_lab4.Models;

namespace tema_lab4.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public UserRepository(TemaLab4Context lab4Context) : base(lab4Context) { }

        public List<User> FindAllActive()
        {
            return _table.GetActiveUsers().ToList();
        }

        public User FindByUsername(string username)
        {
            return _table.FirstOrDefault(u => u.Username.Equals(username));
        }
    }
}
