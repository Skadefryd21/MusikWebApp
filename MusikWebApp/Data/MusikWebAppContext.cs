using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusikWebApp.Models;

namespace MusikWebApp.Data
{
    public class MusikWebAppContext : DbContext
    {
        public MusikWebAppContext (DbContextOptions<MusikWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MusikWebApp.Models.Artist> Artist { get; set; } = default!;

        public DbSet<MusikWebApp.Models.Album>? Album { get; set; }

        public DbSet<MusikWebApp.Models.Genre>? Genre { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Album>()
        //                .HasOne(e => e.Artist)
        //                .WithOne(e => e.Genre);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
