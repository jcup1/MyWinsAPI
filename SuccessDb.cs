using Microsoft.EntityFrameworkCore;

namespace API
{
    public class SuccessDb : DbContext
    {
        //Reference our success table using this
        public DbSet<Success> Successes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./Successes.db");
        }
    }
}