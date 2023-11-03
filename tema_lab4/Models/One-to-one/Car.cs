using tema_lab4.Models.Base;
using tema_lab4.Models.One_to_many;

namespace tema_lab4.Models.One_to_one
{
    public class Car : BaseEntity
    {
        public int? HorsePower { get; set; }

        public string? Model {  get; set; }

        public Team Team { get; set; }

        public Guid TeamId { get; set; }
    }
}
