using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEF_SQL.Model
{
    class WebExplorerContext : DbContext
    {
        public DbSet<File>Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public WebExplorerContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=328328");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Folder>()
                .HasData(new Folder { ID = 1, Name = "Root" });
            modelBuilder.Entity<Node>()
                .HasOne(n => n.ParentFolder)
                .WithMany(n => n.Items)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
