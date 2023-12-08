using Microsoft.AspNetCore.Identity;
using tema_lab4.Models.Base;
using tema_lab4.Models.Enums;

namespace tema_lab4.Models
{
    public class User : BaseEntity
    {
        public string FirstName {  get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username {  get; set; }

        public string Password { get; set; }

        public Role Role {  get; set; }
        public bool IsDeleted { get; internal set; }
    }
}
