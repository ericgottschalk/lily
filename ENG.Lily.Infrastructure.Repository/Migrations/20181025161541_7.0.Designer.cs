﻿// <auto-generated />
using System;
using ENG.Lily.Infaestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ENG.Lily.Infrastructure.Repository.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20181025161541_7.0")]
    partial class _70
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreate");

                    b.Property<int>("Level");

                    b.Property<int>("ProjectId");

                    b.Property<string>("Text")
                        .HasMaxLength(300);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Fund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Aumont");

                    b.Property<int>("CreditCardCompany");

                    b.Property<string>("CreditCardLastFourDigits")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<DateTime>("DateCreate");

                    b.Property<bool>("IsConfirmed");

                    b.Property<int>("ProjectId");

                    b.Property<string>("TransactionId")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Fund");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.GameGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.ManyToMany.PlatformProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlatformId");

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("PlatformId");

                    b.HasIndex("ProjectId");

                    b.ToTable("PlatformProject");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectId");

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Platform");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<int>("GenreId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("TargetReleaseYear");

                    b.Property<int>("UserId");

                    b.Property<string>("WhyInvest")
                        .IsRequired()
                        .HasMaxLength(750);

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("GenreId");

                    b.HasIndex("Name");

                    b.HasIndex("UserId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(250);

                    b.Property<string>("Country")
                        .HasMaxLength(250);

                    b.Property<DateTime>("DateCreate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Phrase")
                        .HasMaxLength(100);

                    b.Property<string>("ProfilePictureUrl");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.Property<string>("WebSite")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Feedback", b =>
                {
                    b.HasOne("ENG.Lily.Domain.Entities.Project", "Project")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProjectId");

                    b.HasOne("ENG.Lily.Domain.Entities.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Fund", b =>
                {
                    b.HasOne("ENG.Lily.Domain.Entities.Project", "Project")
                        .WithMany("Funds")
                        .HasForeignKey("ProjectId");

                    b.HasOne("ENG.Lily.Domain.Entities.User", "User")
                        .WithMany("SendedFunds")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.ManyToMany.PlatformProject", b =>
                {
                    b.HasOne("ENG.Lily.Domain.Entities.Platform", "Platform")
                        .WithMany("Projects")
                        .HasForeignKey("PlatformId");

                    b.HasOne("ENG.Lily.Domain.Entities.Project", "Project")
                        .WithMany("Platforms")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Media", b =>
                {
                    b.HasOne("ENG.Lily.Domain.Entities.Project", "Project")
                        .WithMany("Media")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ENG.Lily.Domain.Entities.Project", b =>
                {
                    b.HasOne("ENG.Lily.Domain.Entities.GameGenre", "Genre")
                        .WithMany("Projects")
                        .HasForeignKey("GenreId");

                    b.HasOne("ENG.Lily.Domain.Entities.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
