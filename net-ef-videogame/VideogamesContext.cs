using Microsoft.EntityFrameworkCore;

namespace net_ef_videogame
{
    public class VideogamesContext : DbContext
    {


        private string SqlString = "Data Source=localhost;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=db_videogames_test;";
        public DbSet<Videogames> Videogames { get; set; }

        public DbSet<SoftwareHouse> SoftwareHouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlString);
        }
    }


}
