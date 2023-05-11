using System;
using Microsoft.EntityFrameworkCore;
using BreweryManagementSystem.DataContext.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BreweryManagementSystem.DataContext.EntityConfiguration
{
    public class BreweryBeerConfiguration : IEntityTypeConfiguration<BreweryBeerDo>
    {
        public BreweryBeerConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<BreweryBeerDo> builder)
        {
            builder.ToTable("Brewery_Beer");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.BeerId).HasColumnName("BeerId");
            builder.Property(p => p.BreweryId).HasColumnName("BreweryId");
            
        }
    }
}