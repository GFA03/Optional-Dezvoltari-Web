namespace tema_lab4.Models.DTOs
{
    public class TeamDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int? FoundedYear { get; set; }

        public string? Country { get; set; }
    }
}
