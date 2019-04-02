﻿// <auto-generated />
using System;
using DVDCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DVDCollection.Migrations
{
    [DbContext(typeof(DVDContext))]
    [Migration("20190402172247_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("DVDCollection.Models.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActorFullName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ActorNotes")
                        .HasMaxLength(300);

                    b.HasKey("ActorID");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("DVDCollection.Models.Certificate", b =>
                {
                    b.Property<int>("CertificateID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertificateName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("CertificateID");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("DVDCollection.Models.FilmActorRole", b =>
                {
                    b.Property<int>("FilmTitleID");

                    b.Property<int>("ActorID");

                    b.Property<int>("RoleID");

                    b.Property<string>("CharacterName")
                        .HasMaxLength(60);

                    b.Property<string>("CharacterDesc")
                        .HasMaxLength(100);

                    b.HasKey("FilmTitleID", "ActorID", "RoleID", "CharacterName");

                    b.HasIndex("ActorID");

                    b.HasIndex("RoleID");

                    b.ToTable("FilmActorRole");
                });

            modelBuilder.Entity("DVDCollection.Models.FilmTitle", b =>
                {
                    b.Property<int>("FilmTitleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CertificateID");

                    b.Property<string>("FilmAdditionalInfo")
                        .HasMaxLength(300);

                    b.Property<int>("FilmDuration");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("FilmReleaseDate");

                    b.Property<string>("FilmStory")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int>("GenreID");

                    b.HasKey("FilmTitleID");

                    b.HasIndex("CertificateID");

                    b.HasIndex("GenreID");

                    b.ToTable("FilmTitle");
                });

            modelBuilder.Entity("DVDCollection.Models.FilmTitleProducer", b =>
                {
                    b.Property<int>("ProducerID");

                    b.Property<int>("FilmTitleID");

                    b.HasKey("ProducerID", "FilmTitleID");

                    b.HasIndex("FilmTitleID");

                    b.ToTable("FilmTitleProducer");
                });

            modelBuilder.Entity("DVDCollection.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("GenreID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DVDCollection.Models.Producer", b =>
                {
                    b.Property<int>("ProducerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProducerEmail");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ProducerWeb");

                    b.HasKey("ProducerID");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("DVDCollection.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RolName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DVDCollection.Models.FilmActorRole", b =>
                {
                    b.HasOne("DVDCollection.Models.Actor", "Actor")
                        .WithMany("FilmActorRoles")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DVDCollection.Models.FilmTitle", "FilmTitle")
                        .WithMany("FilmActorRoles")
                        .HasForeignKey("FilmTitleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DVDCollection.Models.Role", "Rol")
                        .WithMany("FilmActorRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DVDCollection.Models.FilmTitle", b =>
                {
                    b.HasOne("DVDCollection.Models.Certificate", "Certificate")
                        .WithMany("FilmTitles")
                        .HasForeignKey("CertificateID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DVDCollection.Models.Genre", "Genre")
                        .WithMany("FilmTitles")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DVDCollection.Models.FilmTitleProducer", b =>
                {
                    b.HasOne("DVDCollection.Models.FilmTitle", "FilmTitle")
                        .WithMany("FilmTitleProducers")
                        .HasForeignKey("FilmTitleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DVDCollection.Models.Producer", "Producer")
                        .WithMany("FilmTitleProducers")
                        .HasForeignKey("ProducerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}