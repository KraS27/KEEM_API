using KEEM_Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEEM_DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Poi> Pois { get; set; } 
        public DbSet<OwnerType> OwnerTypes { get; set; }


        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Poi>(entity =>
            {
                entity.HasKey(p => p.Id)
                    .HasName("Primary");

                entity.ToTable("Poi");

                entity.Property(p => p.IdOfUser).HasColumnName("id_of_user");
                entity.Property(p => p.OwnerTypeId).HasColumnName("owner_type");
                entity.Property(p => p.CoordLat).HasColumnName("Coord_Lat");
                entity.Property(p => p.CoordLng).HasColumnName("Coord_Lng");
                entity.Property(p => p.Description).HasMaxLength(100);
                entity.Property(p => p.NameObject)
                    .HasMaxLength(200)
                    .HasColumnName("Name_Object");
            });

            builder.Entity<OwnerType>(entity =>
            {
                entity.HasKey(o => o.Id)
                    .HasName("Primary");

                entity.ToTable("owner_types");

                entity.Property(o => o.Type).HasColumnName("type");
            });
        }
    }
}
