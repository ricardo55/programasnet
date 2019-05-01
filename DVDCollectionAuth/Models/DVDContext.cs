using DVDCollection.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





namespace DVDCollection.Models
{
    public class DVDContext : IdentityDbContext<User>
    {
        public DVDContext(DbContextOptions<DVDContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<FilmActorRole> FilmActorRole { get; set; }
        public DbSet<FilmTitleProducer> FilmTitleProducer { get; set; }
        public DbSet<FilmTitle> FilmTitle { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Certificate>().ToTable("Certificate");
            modelBuilder.Entity<FilmActorRole>().ToTable("FilmActorRole");
            modelBuilder.Entity<FilmTitleProducer>().ToTable("FilmTitleProducer");
            modelBuilder.Entity<FilmTitle>().ToTable("FilmTitle");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Producer>().ToTable("Producer");
            modelBuilder.Entity<Role>().ToTable("Role");

            modelBuilder.Entity<FilmActorRole>()
                .HasKey(c => new { c.FilmTitleID, c.ActorID, c.RoleID, c.CharacterName });

            modelBuilder.Entity<FilmTitleProducer>()
                .HasKey(c => new { c.ProducerID, c.FilmTitleID });
        }
    }
}