using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebExplorerWithKendoUI.Models
{
    public class WebExplorerContext : DbContext
    {
        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Node> Nodes { get; set; }
       // public DbSet<FileExtension> FileExtensions { get; set; }
        public WebExplorerContext(DbContextOptions<WebExplorerContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
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
