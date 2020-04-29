using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Models
{
    public class SivrContext : DbContext
    {
        public SivrContext(DbContextOptions<SivrContext> options) 
            : base(options) 
        {
        }

        public DbSet<MetaData> MetaDatas { get; set; }
        public DbSet<ImageNetConceptScore> ImageNetConceptScores { get; set; }
        public DbSet<ImageNetConceptName> ImageNetConceptNames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MetaData>(entity => 
            {
                entity.ToTable(nameof(MetaData));

                entity.HasKey(x => x.V3CId);
                entity.HasAlternateKey(x => x.SourceOrigId);

                entity.Property(x => x.V3CId).IsRequired();
                entity.Property(x => x.Width).IsRequired();
                entity.Property(x => x.Height).IsRequired();
                entity.Property(x => x.Duration).IsRequired();
            });

            modelBuilder.Entity<ImageNetConcept>(entity =>
            {
                entity.ToTable(nameof(ImageNetConcept));

                entity.HasKey(x => x.ImageNetConceptId);
            });

            modelBuilder.Entity<ImageNetConceptName>(entity =>
            {
                entity.ToTable(nameof(ImageNetConceptName));

                entity.HasKey(x => x.ImageNetConceptNameId);
                entity.HasOne(x => x.ImageNetConcept);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable(nameof(Video));

                entity.HasKey(x => x.V3CId);
            });

            modelBuilder.Entity<Keyframe>(entity =>
            {
                entity.ToTable(nameof(Keyframe));

                entity.HasKey(x => new { x.V3CId, x.KeyframeNumber });
            });

            modelBuilder.Entity<ImageNetConceptScore>(entity =>
            {
                entity.ToTable(nameof(ImageNetConceptScore));

                entity.HasKey(x => new { x.V3CId, x.KeyframeNumber, x.ImageNetConceptId });
                entity.HasOne(x => x.ImageNetConcept);
                entity.HasOne(x => x.Keyframe);
                entity.HasIndex(x => x.ImageNetConceptId);
                entity.HasIndex(x => x.Score);
            });
        }
    }
}
