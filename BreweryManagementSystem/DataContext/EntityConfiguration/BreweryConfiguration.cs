using System;
using Microsoft.EntityFrameworkCore;
using BreweryManagementSystem.DataContext.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BreweryManagementSystem.DataContext.EntityConfiguration
{
	public class BreweryConfiguration: IEntityTypeConfiguration<BreweryDo>
    {
		public BreweryConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<BreweryDo> builder)
        {
            builder.ToTable("brewery");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnName("Name");
            //builder.HasMany(p => p.Beers).WithOne(p => p.Brewery).HasForeignKey(f => new {Id = f.Id});          
        }
    }
}

