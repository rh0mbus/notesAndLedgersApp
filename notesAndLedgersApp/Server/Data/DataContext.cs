using Microsoft.EntityFrameworkCore;
using notesAndLedgersApp.Shared;

namespace notesAndLedgersApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Campaign> Campaigns { get; set; }

        public DbSet<Session> Sessions { get; set; }
    }
}
