using System.ComponentModel.DataAnnotations;
using tema_lab4.Models.Base;
using tema_lab4.Models.One_to_one;

namespace tema_lab4.Models.One_to_many
{
    public class Team : BaseEntity
    {
        public int? FoundedYear {  get; set; }

        public string? Country {  get; set; }
        
        public ICollection<Pilot>? Pilots {  get; set; }

        public ICollection<Sponsor>? Sponsors { get; set; }

        public Car Car { get; set; }
    }
}
