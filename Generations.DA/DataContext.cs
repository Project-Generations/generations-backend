using Generations.DA.Entities;
using Generations.DA.Entities.Pokemon;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Generations.DA
{
    public class DataContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teams>().ToTable("pokemon_teams");
            modelBuilder.Entity<CreatedPokemons>().ToTable("pokemons");
            modelBuilder.Entity<Evs>().ToTable("evs");
            modelBuilder.Entity<Ivs>().ToTable("ivs");
            modelBuilder.Entity<Items>().ToTable("items");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Teams> Teams { get; set; }
        public DbSet<CreatedPokemons> CreatedPokemons { get; set; }
        public DbSet<Evs> Evs { get; set; }
        public DbSet<Ivs> Ivs { get; set; }
        public DbSet<Items> Items { get; set; }
    }
}