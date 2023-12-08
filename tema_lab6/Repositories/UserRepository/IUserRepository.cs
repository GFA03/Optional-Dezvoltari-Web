using tema_lab4.Repositories.GenericRepository;
using tema_lab4.Models;

namespace tema_lab4.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByUsername(string username);

        List<User> FindAllActive();
    }
}
