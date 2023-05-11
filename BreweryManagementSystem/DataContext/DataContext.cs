using System;
using BreweryManagementSystem.DataContext.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using BreweryManagementSystem.DataContext.Entities;




namespace BreweryManagementSystem.DataContext
{
	public class DataContext : DbContext
	{
        public DbSet<BreweryDo> Brewery { set; get; }
        public DbSet<BeerDo> Beer  { set; get; }
        public DbSet<BreweryBeerDo> BreweryBeer { set; get; }         

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=localhost,57000;user=sa;password=quLRYP22;database=BreweryManagementSystem;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<BreweryDo>(new BreweryConfiguration());
            modelBuilder.ApplyConfiguration<BeerDo>(new BeerConfiguration());
            modelBuilder.ApplyConfiguration<BreweryBeerDo>(new BreweryBeerConfiguration());
        }

        public DataContext()
		{

        }
	}
}

