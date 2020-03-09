﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleAPI.Infrastructure;

namespace SampleAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200309202742_add field Photo in categories model")]
    partial class addfieldPhotoincategoriesmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleAPI.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Photo");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 655, DateTimeKind.Local).AddTicks(5346),
                            Description = "En esta categoria encontrarás cursos de Blender y Unreal",
                            IsActive = true,
                            Name = "Video Juegos",
                            Photo = "dsfdfdfggggg",
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 655, DateTimeKind.Local).AddTicks(6102)
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("Photo");

                    b.Property<DateTime?>("PostedAt");

                    b.Property<double>("Rating");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Username");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 656, DateTimeKind.Local).AddTicks(1767),
                            Description = "En esta categoria encontrarás temas de Blender",
                            IsActive = true,
                            IsPublished = false,
                            Name = "Blender",
                            Photo = "react.png",
                            Rating = 0.0,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 656, DateTimeKind.Local).AddTicks(2496),
                            Username = "Mr. Sample"
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<int>("SubjectId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(9170),
                            IsActive = true,
                            Name = "Contenido Tema1",
                            SubjectId = 1,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(9943),
                            Url = "www.google.com"
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsCorrect");

                    b.Property<int>("QuestionId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Respuesta Pregunta 1",
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(8561),
                            IsActive = true,
                            IsCorrect = true,
                            QuestionId = 1,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(9239)
                        },
                        new
                        {
                            Id = 2,
                            Content = "Respuesta Pregunta 2",
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(9949),
                            IsActive = true,
                            IsCorrect = false,
                            QuestionId = 1,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(9955)
                        },
                        new
                        {
                            Id = 3,
                            Content = "Respuesta Pregunta 3",
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(9964),
                            IsActive = true,
                            IsCorrect = false,
                            QuestionId = 1,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(9965)
                        },
                        new
                        {
                            Id = 4,
                            Content = "Respuesta Pregunta 4",
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(9968),
                            IsActive = true,
                            IsCorrect = false,
                            QuestionId = 1,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(9970)
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Pregunta Curso 1",
                            CourseId = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(3725),
                            IsActive = true,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 658, DateTimeKind.Local).AddTicks(4435)
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4066),
                            IsActive = true,
                            Name = "Tema1 Blender",
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4924)
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.UserContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("Username");

                    b.ToTable("UserContents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContentId = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 659, DateTimeKind.Local).AddTicks(2305),
                            Username = "Mr. Sample"
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.UserCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorrectAnswers");

                    b.Property<int>("CourseId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("IsEnd");

                    b.Property<int>("Progress");

                    b.Property<int>("Rating");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("Username");

                    b.ToTable("UsersCourses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CorrectAnswers = 0,
                            CourseId = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 656, DateTimeKind.Local).AddTicks(9124),
                            IsEnd = false,
                            Progress = 0,
                            Rating = 0,
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 656, DateTimeKind.Local).AddTicks(9658),
                            Username = "Mr. Sample"
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.User", b =>
                {
                    b.Property<string>("Username")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Photo");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "Mr. Sample",
                            CreatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 652, DateTimeKind.Local).AddTicks(4078),
                            Email = "sample@email.com",
                            IsActive = true,
                            LastName = "Sample",
                            Name = "Mr.",
                            Photo = "photo.png",
                            UpdatedAt = new DateTime(2020, 3, 9, 15, 27, 40, 654, DateTimeKind.Local).AddTicks(2436)
                        });
                });

            modelBuilder.Entity("SampleAPI.Domain.Course", b =>
                {
                    b.HasOne("SampleAPI.Domain.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SampleAPI.Domain.User", "User")
                        .WithMany("Course")
                        .HasForeignKey("Username");
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Content", b =>
                {
                    b.HasOne("SampleAPI.Domain.Models.Subject", "Subject")
                        .WithMany("Content")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Option", b =>
                {
                    b.HasOne("SampleAPI.Domain.Models.Question", "Question")
                        .WithMany("Option")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Question", b =>
                {
                    b.HasOne("SampleAPI.Domain.Course", "Course")
                        .WithMany("Question")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.Subject", b =>
                {
                    b.HasOne("SampleAPI.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.UserContent", b =>
                {
                    b.HasOne("SampleAPI.Domain.Models.Content", "Content")
                        .WithMany("UserContent")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SampleAPI.Domain.User", "User")
                        .WithMany("UserContent")
                        .HasForeignKey("Username");
                });

            modelBuilder.Entity("SampleAPI.Domain.Models.UserCourse", b =>
                {
                    b.HasOne("SampleAPI.Domain.Course", "Course")
                        .WithMany("UserCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SampleAPI.Domain.User", "User")
                        .WithMany("UserCourse")
                        .HasForeignKey("Username");
                });
#pragma warning restore 612, 618
        }
    }
}