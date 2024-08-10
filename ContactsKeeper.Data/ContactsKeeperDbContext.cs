using ContactsKeeper.Data.DataEntities;
using Microsoft.EntityFrameworkCore;

namespace ContactsKeeper.Data
{
    public class ContactsKeeperDbContext : DbContext
    {
        public DbSet<ContactEntity> ContactEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=ContactsKeeperDatabase;Trusted_Connection=True;Encrypt=false;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}