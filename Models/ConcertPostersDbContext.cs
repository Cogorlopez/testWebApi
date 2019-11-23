using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TodoApi.Models
{
    public partial class ConcertPostersDbContext : DbContext
    {
        public ConcertPostersDbContext()
        {
        }

        public ConcertPostersDbContext(DbContextOptions<ConcertPostersDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Posters> Posters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:cogor-free-trial.database.windows.net,1433;Initial Catalog=ConcertPostersDb;Persist Security Info=False;User ID=cogor-admin;Password=0M3gaca7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posters>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Artist)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Band)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Venue)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
