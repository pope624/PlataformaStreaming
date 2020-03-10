﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleAPI.Infrastructure;

namespace SampleAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2020, 3, 10, 9, 42, 32, 496, DateTimeKind.Local).AddTicks(2917),
                            Email = "sample@email.com",
                            IsActive = true,
                            LastName = "Sample",
                            Name = "Mr.",
                            Photo = "photo.png",
                            UpdatedAt = new DateTime(2020, 3, 10, 9, 42, 32, 498, DateTimeKind.Local).AddTicks(1851)
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
