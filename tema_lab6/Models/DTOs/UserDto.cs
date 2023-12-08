namespace tema_lab4.Models.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; } = default!;

        public string Email { get; set; }

        public string Username { get; set; }
    }
}
