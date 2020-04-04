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
        }
    }
}
