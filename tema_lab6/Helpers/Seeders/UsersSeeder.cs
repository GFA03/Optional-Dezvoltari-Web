using tema_lab4.Data;
using tema_lab4.Models;

namespace tema_lab4.Helpers.Seeders
{
    public class UsersSeeder
    {
        public readonly TemaLab4Context _temaLab4Context;

        public UsersSeeder(TemaLab4Context temaLab4Context)
        {
            _temaLab4Context = temaLab4Context;
        }

        public void SeedInitialUsers()
        {
            if (!_temaLab4Context.Users.Any())
            {
                var user1 = new User
                {
                    FirstName = "Fist name User 1",
                    LastName = "Last name User 1",
                    IsDeleted = false,
                    Email = "user1@mail.com",
                    Username = "user1"
                };

                var user2 = new User
                {
                    FirstName = "Fist name User 2",
                    LastName = "Last name User 2",
                    IsDeleted = false,
                    Email = "user2@mail.com",
                    Username = "user2"
                };

                _temaLab4Context.Users.Add(user1);
                _temaLab4Context.Users.Add(user2);

                _temaLab4Context.SaveChanges();
            }
        }
    }
}
