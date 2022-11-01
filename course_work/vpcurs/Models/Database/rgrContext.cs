using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace vpcurs.Models.Database
{
    public partial class rgrContext : DbContext
    {
        public rgrContext()
        {
        }

        public rgrContext(DbContextOptions<rgrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Match> Matches { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<PlayerResult> PlayerResults { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source = D:\\vpcurs_copy3_final2\\vpcurs\\Assets\\rgr.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("Match");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Player");

                entity.Property(e => e.Mvp).HasColumnName("MVP");
            });

            modelBuilder.Entity<PlayerResult>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.HasOne(d => d.NameNavigation)
                    .WithOne(p => p.PlayerResult)
                    .HasForeignKey<PlayerResult>(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Team");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
