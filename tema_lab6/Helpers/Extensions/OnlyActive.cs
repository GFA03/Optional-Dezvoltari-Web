using tema_lab4.Models;

namespace tema_lab4.Helpers.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<User> GetActiveUsers(this IQueryable<User> query)
        {
            return query.Where(x => !x.isDeleted);
        }
    }
}
