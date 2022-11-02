using Microsoft.EntityFrameworkCore;
using notesAndLedgersApp.Shared;
using System.Security.Cryptography.Xml;

namespace notesAndLedgersApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Campaign> Campaigns { get; set; }
    }
}
