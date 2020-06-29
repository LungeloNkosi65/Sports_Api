using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sports_Api
{
    public partial class HollywoodBetsRepDbContext : DbContext
    {
        public HollywoodBetsRepDbContext()
        {
        }

        public HollywoodBetsRepDbContext(DbContextOptions<HollywoodBetsRepDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BetType> BetType { get; set; }
        public virtual DbSet<BetTypeMarket> BetTypeMarket { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<SportCountry> SportCountry { get; set; }
        public virtual DbSet<SportsTournament> SportsTournament { get; set; }
        public virtual DbSet<SportsTree> SportsTree { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }
        public virtual DbSet<TournamentBetType> TournamentBetType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=(LocalDb)\\LocalDBDemo;Database=HollywoodBetsRepDb;Trusted_Connection=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BetType>(entity =>
            {
                entity.Property(e => e.BetTypeId).ValueGeneratedNever();

                entity.Property(e => e.BetTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BetTypeMarket>(entity =>
            {
                entity.Property(e => e.BetTypeMarketId).ValueGeneratedNever();

                entity.HasOne(d => d.BetType)
                    .WithMany(p => p.BetTypeMarket)
                    .HasForeignKey(d => d.BetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BetTypeMarket_BetType");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.BetTypeMarket)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BetTypeMarket_Market");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).ValueGeneratedNever();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).ValueGeneratedNever();

                entity.Property(e => e.EeventDate).HasColumnType("date");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.TournamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Tournament");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.Property(e => e.MarketId).ValueGeneratedNever();

                entity.Property(e => e.MarketName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SportCountry>(entity =>
            {
                entity.Property(e => e.SportCountryId).ValueGeneratedNever();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SportCountry)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportCountry_Country");

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.SportCountry)
                    .HasForeignKey(d => d.SportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportCountry_SportsTree");
            });

            modelBuilder.Entity<SportsTournament>(entity =>
            {
                entity.HasKey(e => e.SportTourtnamentId);

                entity.Property(e => e.SportTourtnamentId).ValueGeneratedNever();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SportsTournament)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportsTournament_Country");

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.SportsTournament)
                    .HasForeignKey(d => d.SportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportsTournament_SportsTree");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.SportsTournament)
                    .HasForeignKey(d => d.TournamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SportsTournament_Tournament");
            });

            modelBuilder.Entity<SportsTree>(entity =>
            {
                entity.HasKey(e => e.SportId);

                entity.Property(e => e.SportId).ValueGeneratedNever();

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.Property(e => e.TournamentId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TournamentBetType>(entity =>
            {
                entity.HasKey(e => e.TbTid);

                entity.Property(e => e.TbTid)
                    .HasColumnName("TbTId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BetType)
                    .WithMany(p => p.TournamentBetType)
                    .HasForeignKey(d => d.BetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TournamentBetType_BetType");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.TournamentBetType)
                    .HasForeignKey(d => d.TournamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TournamentBetType_Tournament");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
