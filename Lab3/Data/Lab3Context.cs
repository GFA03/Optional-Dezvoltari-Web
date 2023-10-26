using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
    public class Lab3Context : DbContext
    {
        public DbSet<Student> Students {  get; set; }
        public Lab3Context(DbContextOptions<Lab3Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
