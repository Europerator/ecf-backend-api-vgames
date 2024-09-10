using Ecf.Vgames.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecf.Vgames.Services
{
    public class DbContextGizmondo: DbContext
    {
        public DbSet­<Gizmondo> Gizmondos { get; set; }
        public DbSet<Publisher> Publishers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GizmondoDb;Trusted_Connection=True;");
        }
    }
}
