using System;
using Microsoft.EntityFrameworkCore;
using BreweryManagementSystem.DataContext.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BreweryManagementSystem.DataContext.EntityConfiguration
{
    public class BeerConfiguration : IEntityTypeConfiguration<BeerDo>
    {
        public void Configure(EntityTypeBuilder<BeerDo> builder)
        {
            builder.ToTable("Beer");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnName("Name");
            builder.Property(p => p.RetailPrice).HasColumnName("RetailPrice");
            builder.Property(p => p.WholeSalePrice).HasColumnName("WholeSalePrice");
            builder.HasOne(p => p.Brewery).WithMany(p => p.Beers).HasForeignKey(f => new {Id = f.Id}); 
        }
    }
}

