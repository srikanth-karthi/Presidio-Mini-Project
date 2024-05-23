﻿// <auto-generated />
using System;
using Job_Portal_Application.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Job_Portal_Application.Migrations
{
    [DbContext(typeof(JobportalContext))]
    [Migration("20240523154628_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Job_Portal_Application.Models.AreasOfInterest", b =>
                {
                    b.Property<Guid>("AreasOfInterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Lpa")
                        .HasColumnType("real");

                    b.Property<Guid>("TitleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AreasOfInterestId");

                    b.HasIndex("TitleId");

                    b.HasIndex("UserId");

                    b.ToTable("AreasOfInterests");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CompanySize")
                        .HasColumnType("int");

                    b.Property<string>("CompanyWebsite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HasCode")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Education", b =>
                {
                    b.Property<Guid>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly?>("EndYear")
                        .HasColumnType("date");

                    b.Property<string>("InstitutionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsCurrentlyStudying")
                        .HasColumnType("bit");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Percentage")
                        .HasColumnType("real");

                    b.Property<DateOnly>("StartYear")
                        .HasColumnType("date");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EducationId");

                    b.HasIndex("UserId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Experience", b =>
                {
                    b.Property<Guid>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateOnly>("EndYear")
                        .HasColumnType("date");

                    b.Property<DateOnly>("StartYear")
                        .HasColumnType("date");

                    b.Property<Guid>("TitleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExperienceId");

                    b.HasIndex("TitleId");

                    b.HasIndex("UserId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Job", b =>
                {
                    b.Property<Guid>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<float?>("ExperienceRequired")
                        .HasColumnType("real");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("JobType")
                        .HasColumnType("int");

                    b.Property<float?>("Lpa")
                        .HasColumnType("real");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("TitleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("JobId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TitleId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.JobActivity", b =>
                {
                    b.Property<Guid>("UserJobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AppliedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserJobId");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("JobActivities");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.JobSkills", b =>
                {
                    b.Property<Guid>("JobSkillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("JobSkillsId");

                    b.HasIndex("JobId");

                    b.HasIndex("SkillId");

                    b.ToTable("JobSkills");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Skill", b =>
                {
                    b.Property<Guid>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Skill_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            SkillId = new Guid("ae6b7ea3-5055-4ca7-a860-de5d58d3890d"),
                            Skill_Name = "HTML"
                        },
                        new
                        {
                            SkillId = new Guid("b7832aba-7f5b-4c28-a8df-766499dd7fe7"),
                            Skill_Name = "CSS"
                        },
                        new
                        {
                            SkillId = new Guid("79c6de87-9c33-4b3d-add4-185e733316d5"),
                            Skill_Name = "JavaScript"
                        },
                        new
                        {
                            SkillId = new Guid("b3c3968a-833f-4164-bc3e-18f9240ecdd7"),
                            Skill_Name = "TypeScript"
                        },
                        new
                        {
                            SkillId = new Guid("c9c61b4c-da61-4d56-8de1-f9fecaef3c52"),
                            Skill_Name = "React"
                        },
                        new
                        {
                            SkillId = new Guid("672eb3d0-96bf-44fd-ac14-989dc4714935"),
                            Skill_Name = "Angular"
                        },
                        new
                        {
                            SkillId = new Guid("ed51425e-8153-4de0-abd5-38ed77ada6b2"),
                            Skill_Name = "Vue"
                        },
                        new
                        {
                            SkillId = new Guid("74cd4eb5-7960-4c72-a822-b39b2059ce52"),
                            Skill_Name = "Node.js"
                        },
                        new
                        {
                            SkillId = new Guid("96fb69a0-6271-4565-b3e8-07567396755d"),
                            Skill_Name = "Express"
                        },
                        new
                        {
                            SkillId = new Guid("58a8659b-db0e-44d4-b63d-97ee73e84671"),
                            Skill_Name = "Python"
                        },
                        new
                        {
                            SkillId = new Guid("2906025c-6a27-40c0-8e77-77c1f70a5166"),
                            Skill_Name = "Django"
                        },
                        new
                        {
                            SkillId = new Guid("9d15c9a1-46fa-45c8-af78-2ca6a7bc33c2"),
                            Skill_Name = "Flask"
                        },
                        new
                        {
                            SkillId = new Guid("7d50ce23-3e0c-4a88-a447-ceb6cdb74116"),
                            Skill_Name = "Java"
                        },
                        new
                        {
                            SkillId = new Guid("687b2f43-55a9-4556-8e2a-46328f7b038e"),
                            Skill_Name = "Spring"
                        },
                        new
                        {
                            SkillId = new Guid("6878233d-b16e-4ffd-8215-f8f440bc2885"),
                            Skill_Name = "Kotlin"
                        },
                        new
                        {
                            SkillId = new Guid("ace25e60-7ce8-4d75-8400-76f505fe1b97"),
                            Skill_Name = "Swift"
                        },
                        new
                        {
                            SkillId = new Guid("67134a86-dce5-4e33-98bd-7733402da6c0"),
                            Skill_Name = "Objective-C"
                        },
                        new
                        {
                            SkillId = new Guid("5cb0dc18-1545-4212-b426-ddb9a3d41bfd"),
                            Skill_Name = "Ruby"
                        },
                        new
                        {
                            SkillId = new Guid("2e44da50-0ca3-4394-b127-8c1c811a0b36"),
                            Skill_Name = "Rails"
                        },
                        new
                        {
                            SkillId = new Guid("5e1dcaa0-45bc-4839-b5fc-dbf73d96e690"),
                            Skill_Name = "PHP"
                        });
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Title", b =>
                {
                    b.Property<Guid>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TitleId");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            TitleId = new Guid("ea787459-fe6b-4901-b98b-163a21ff602f"),
                            TitleName = "Full Stack Developer"
                        },
                        new
                        {
                            TitleId = new Guid("4d1d75bf-2532-41c2-a486-2bf54da326bb"),
                            TitleName = "Front End Developer"
                        },
                        new
                        {
                            TitleId = new Guid("fc53a1cb-a89b-4002-9d79-4e6e2ffe02c9"),
                            TitleName = "Back End Developer"
                        },
                        new
                        {
                            TitleId = new Guid("4d009c9f-0622-4f40-bdee-004a9a15414a"),
                            TitleName = "Software Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("adcc2146-34d6-454f-9c80-3d451863977e"),
                            TitleName = "Data Scientist"
                        },
                        new
                        {
                            TitleId = new Guid("9f796fb6-e793-4405-9bc4-122a7c4d36a2"),
                            TitleName = "DevOps Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("a8275914-f582-4c96-9d39-0bbfd5d4cc3c"),
                            TitleName = "Product Manager"
                        },
                        new
                        {
                            TitleId = new Guid("d24d09a1-1c0c-4bf9-91e0-2841e624eb70"),
                            TitleName = "Project Manager"
                        },
                        new
                        {
                            TitleId = new Guid("e645da58-c253-451f-84fa-bca6461b0e81"),
                            TitleName = "Business Analyst"
                        },
                        new
                        {
                            TitleId = new Guid("d305e4ff-16f4-4847-abc4-eda29f9e6e97"),
                            TitleName = "QA Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("e17a32b5-5a8c-412a-8396-1c10251244cd"),
                            TitleName = "UI/UX Designer"
                        },
                        new
                        {
                            TitleId = new Guid("ae797c9b-e4f1-4262-9d3d-28562740c54f"),
                            TitleName = "Mobile Developer"
                        },
                        new
                        {
                            TitleId = new Guid("4227ef28-dff2-4a18-80c4-945bea718a3c"),
                            TitleName = "Security Analyst"
                        },
                        new
                        {
                            TitleId = new Guid("736f8c2a-a757-44f1-9c81-e3927ce11e7e"),
                            TitleName = "Network Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("d3426f51-1e03-4e92-93d2-4e79a0714f24"),
                            TitleName = "Systems Administrator"
                        },
                        new
                        {
                            TitleId = new Guid("8eaa3de8-5fd5-4324-9547-bf194dc5f4e7"),
                            TitleName = "Database Administrator"
                        },
                        new
                        {
                            TitleId = new Guid("c3c5f4aa-3960-42a0-b93b-bebfbf2d3b58"),
                            TitleName = "Cloud Architect"
                        },
                        new
                        {
                            TitleId = new Guid("7f36562e-1ab0-4f01-a4e3-22cb8dc8bca2"),
                            TitleName = "Machine Learning Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("5f09840c-c533-41ff-a490-1be820e77b99"),
                            TitleName = "Artificial Intelligence Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("1e69591e-f47f-484c-bc08-4894f7f8f85e"),
                            TitleName = "Technical Support Engineer"
                        });
                });

            modelBuilder.Entity("Job_Portal_Application.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("HasCode")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioLink")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ResumeUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.UserSkills", b =>
                {
                    b.Property<Guid>("UserSkillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserSkillsId");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.AreasOfInterest", b =>
                {
                    b.HasOne("Job_Portal_Application.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Job_Portal_Application.Models.User", null)
                        .WithMany("AreasOfInterests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Education", b =>
                {
                    b.HasOne("Job_Portal_Application.Models.User", null)
                        .WithMany("Educations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Experience", b =>
                {
                    b.HasOne("Job_Portal_Application.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Job_Portal_Application.Models.User", null)
                        .WithMany("Experiences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Job", b =>
                {
                    b.HasOne("Job_Portal_Application.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Job_Portal_Application.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.JobActivity", b =>
                {
                    b.HasOne("Job_Portal_Application.Models.Job", "Job")
                        .WithMany("JobActivities")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Job_Portal_Application.Models.User", "User")
                        .WithMany("JobActivities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.JobSkills", b =>
                {
                    b.HasOne("Job_Portal_Application.Models.Job", "Job")
                        .WithMany("JobSkills")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Job_Portal_Application.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.UserSkills", b =>
                {
                    b.HasOne("Job_Portal_Application.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Job_Portal_Application.Models.User", "User")
                        .WithMany("UserSkills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Company", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.Job", b =>
                {
                    b.Navigation("JobActivities");

                    b.Navigation("JobSkills");
                });

            modelBuilder.Entity("Job_Portal_Application.Models.User", b =>
                {
                    b.Navigation("AreasOfInterests");

                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("JobActivities");

                    b.Navigation("UserSkills");
                });
#pragma warning restore 612, 618
        }
    }
}