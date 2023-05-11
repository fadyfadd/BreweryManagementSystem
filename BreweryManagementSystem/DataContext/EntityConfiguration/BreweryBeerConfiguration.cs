using System;
using Microsoft.EntityFrameworkCore;

namespace BreweryManagementSystem.DataContext.EntityConfiguration
{
    public class BeerConfiguration : IEntityTypeConfiguration<BeerDo>
    {
        public BeerConfiguration()
        {
        }

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BeerDo> builder)
        {
            builder.ToTable("Beer");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnName("Name");
            builder.Property(p => p.RetailPrice).HasColumnName("RetailPrice");
            builder.Property(p => p.WholeSalePrice).HasColumnName("WholeSalePrice");          
        }
    }
}

