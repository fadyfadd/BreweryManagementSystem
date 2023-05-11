using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BreweryManagementSystem.Models
{
	public partial class BreweryManagementSystemContext
	{
        private AppSettings settings;

        public BreweryManagementSystemContext(IOptions<AppSettings> settings)
        {
            this.settings = settings.Value;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Beer__3214EC07E9871F5F");

                entity.ToTable("Beer");

                entity.HasIndex(e => e.Name, "UQ__Beer__737584F6E086D434").IsUnique();

                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.RetailPrice).HasColumnType("numeric(10, 2)");
                entity.Property(e => e.WholeSalePrice).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<Brewery>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Brewery__3214EC074D9FD39A");

                entity.ToTable("Brewery");

                entity.HasIndex(e => e.Name, "UQ__Brewery__737584F62C68F699").IsUnique();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<BreweryBeer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Brewery___3214EC07A73AAD6A");

                entity.ToTable("Brewery_Beer");

                entity.HasIndex(e => e.BeerId, "UC_Brewery_Beer_3").IsUnique();

                entity.HasOne(d => d.Beer).WithOne(p => p.BreweryBeer)
                    .HasForeignKey<BreweryBeer>(d => d.BeerId)
                    .HasConstraintName("FK_Brewery_Beer_1");

                entity.HasOne(d => d.Brewery).WithMany(p => p.BreweryBeers)
                    .HasForeignKey(d => d.BreweryId)
                    .HasConstraintName("FK_Brewery_Beer_2");
            });

            modelBuilder.Entity<WholeSaler>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__WholeSal__3214EC078BCE57F4");

                entity.ToTable("WholeSaler");

                entity.HasIndex(e => e.Name, "UQ__WholeSal__737584F65FEB122B").IsUnique();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<WholeSalerBeer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__wholeSal__3214EC077C6BBB4A");

                entity.ToTable("wholeSaler_Beer");

                entity.HasIndex(e => new { e.BeerId, e.WholeSalerId }, "UC_WholeSaler_Beer_3").IsUnique();

                entity.HasIndex(e => new { e.BeerId, e.WholeSalerId }, "UC_WholeSaler_Stock_2").IsUnique();

                entity.HasOne(d => d.Beer).WithMany(p => p.WholeSalerBeers)
                    .HasForeignKey(d => d.BeerId)
                    .HasConstraintName("FK_WholeSaler_Beer_1");

                entity.HasOne(d => d.WholeSaler).WithMany(p => p.WholeSalerBeers)
                    .HasForeignKey(d => d.WholeSalerId)
                    .HasConstraintName("FK_WholeSaler_Beer_2");
            });

            modelBuilder.Entity<WholeSalerStock>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__WholeSal__3214EC07C5FB935C");

                entity.ToTable("WholeSaler_Stock");

                entity.HasOne(d => d.DefinedBeer).WithMany(p => p.WholeSalerStocks)
                    .HasForeignKey(d => d.DefinedBeerId)
                    .HasConstraintName("FK_WholeSaler_Stock_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}

