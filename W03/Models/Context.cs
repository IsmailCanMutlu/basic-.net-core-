using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace W03.Models
{
    public partial class Contex : DbContext
    {
        public Contex()
        {
        }

        public Contex(DbContextOptions<Contex> options)
            : base(options)
        {
        }

        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Series> Seriess { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}