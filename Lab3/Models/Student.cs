using Lab3.Models.Base;

namespace Lab3.Models
{
    public class Student : BaseEntity
    {
        public string? Name {  get; set; }
        public int Age { get; set; }
    }
}
