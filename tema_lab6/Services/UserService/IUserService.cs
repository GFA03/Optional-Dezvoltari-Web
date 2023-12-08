using tema_lab4.Models.DTOs;

namespace tema_lab4.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsers();

        UserDto GetUserByUsername(string username);
    }
}
