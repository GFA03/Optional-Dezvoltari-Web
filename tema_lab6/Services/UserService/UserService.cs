using AutoMapper;
using tema_lab4.Models.DTOs;
using tema_lab4.Repositories.UserRepository;

namespace tema_lab4.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var userList = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserDto>>(userList);
        }

        public UserDto GetUserByUsername(string username)
        {
            var user = _userRepository.FindByUsername(username);

            //var userDto = new UserDto
            //{
            //    Username = user.Username,
            //    Email = user.Email,
            //    FullName = user.FirstName + user.LastName
            //};

            return _mapper.Map<UserDto>(user);
        }
    }
}
