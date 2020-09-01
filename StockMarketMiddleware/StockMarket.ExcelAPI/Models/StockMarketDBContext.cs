using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StockMarket.ExcelAPI.Models
{
    public partial class StockMarketDBContext : DbContext
    {
        public StockMarketDBContext()
        {
        }

        public StockMarketDBContext(DbContextOptions<StockMarketDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<StockPrice> StockPrice { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SOCDNET05;Database=StockMarketDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyCode)
                    .HasName("PK__Company__11A0134AD54E6AA1");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ceo)
                    .HasColumnName("CEO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockPrice>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK__StockPri__FFEE74313D2E5828");

                entity.Property(e => e.RowId).ValueGeneratedNever();

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.StockExchange)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.StockPrice)
                    .HasForeignKey(d => d.CompanyCode)
                    .HasConstraintName("FK__StockPric__Compa__300424B4");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C1500EA9D");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmed)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
