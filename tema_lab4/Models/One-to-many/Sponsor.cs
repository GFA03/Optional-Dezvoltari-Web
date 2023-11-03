using tema_lab4.Models.Base;

namespace tema_lab4.Models.One_to_many
{
    public class Sponsor : BaseEntity
    {
        public int? Buget { get; set; }

        public string? Country { get; set; }

        public Team Team { get; set; }

        public Guid TeamId { get; set; }
    }
}
