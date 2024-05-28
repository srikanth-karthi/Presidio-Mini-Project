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
    [Migration("20240528163440_init")]
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

                    b.Property<DateOnly>("DatePosted")
                        .HasColumnType("date");

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

                    b.Property<DateOnly>("AppliedDate")
                        .HasColumnType("date");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ResumeViewed")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
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
                            SkillId = new Guid("23b60721-74b9-4209-9a57-386ffeebd57f"),
                            Skill_Name = "HTML"
                        },
                        new
                        {
                            SkillId = new Guid("6cdbb00b-86c3-47db-b8ec-51dfff2e8cb1"),
                            Skill_Name = "CSS"
                        },
                        new
                        {
                            SkillId = new Guid("699e7a3a-eb03-4191-ae61-26ab54959ee4"),
                            Skill_Name = "JavaScript"
                        },
                        new
                        {
                            SkillId = new Guid("f0817fdc-f342-4509-a8fd-6d360fac73d0"),
                            Skill_Name = "TypeScript"
                        },
                        new
                        {
                            SkillId = new Guid("6ce122a6-91f9-4e8f-9050-0652ff78ff74"),
                            Skill_Name = "React"
                        },
                        new
                        {
                            SkillId = new Guid("7dd97511-e415-4f7f-9df6-b98faf5b628d"),
                            Skill_Name = "Angular"
                        },
                        new
                        {
                            SkillId = new Guid("141e4f69-6f3b-4c34-83f9-b312f627421e"),
                            Skill_Name = "Vue"
                        },
                        new
                        {
                            SkillId = new Guid("6181eb1f-21d7-4e47-8817-c4821c5c81af"),
                            Skill_Name = "Node.js"
                        },
                        new
                        {
                            SkillId = new Guid("ced03da9-accd-4c3a-8bf4-e8200653eab2"),
                            Skill_Name = "Express"
                        },
                        new
                        {
                            SkillId = new Guid("7d44b987-cb75-4383-a496-47570830adea"),
                            Skill_Name = "Python"
                        },
                        new
                        {
                            SkillId = new Guid("c54d9df3-48a7-4f8b-a486-d302f857caa4"),
                            Skill_Name = "Django"
                        },
                        new
                        {
                            SkillId = new Guid("577b76eb-a170-428a-b9f9-3274d985ca3a"),
                            Skill_Name = "Flask"
                        },
                        new
                        {
                            SkillId = new Guid("7b632a0b-c4bb-45e7-a7d6-60c38e0a639a"),
                            Skill_Name = "Java"
                        },
                        new
                        {
                            SkillId = new Guid("1835f19e-1b08-4eb9-a053-a7d9e7aa7874"),
                            Skill_Name = "Spring"
                        },
                        new
                        {
                            SkillId = new Guid("b39270a0-f3c3-401b-bc64-fe948385be51"),
                            Skill_Name = "Kotlin"
                        },
                        new
                        {
                            SkillId = new Guid("2880f9a8-c59d-4892-8295-057484923ba0"),
                            Skill_Name = "Swift"
                        },
                        new
                        {
                            SkillId = new Guid("4f4ae1b2-532b-472c-9de2-88ae0995c295"),
                            Skill_Name = "Objective-C"
                        },
                        new
                        {
                            SkillId = new Guid("4ac34316-88ae-4ba3-8461-ab04b3e3adaa"),
                            Skill_Name = "Ruby"
                        },
                        new
                        {
                            SkillId = new Guid("a591a5b4-94b6-4588-8806-aa1d7da4e040"),
                            Skill_Name = "Rails"
                        },
                        new
                        {
                            SkillId = new Guid("5b5535e7-f592-4006-b257-35d015c67115"),
                            Skill_Name = "PHP"
                        },
                        new
                        {
                            SkillId = new Guid("b9e0013e-7dec-40d1-ad8c-d404d66fdd12"),
                            Skill_Name = "C#"
                        },
                        new
                        {
                            SkillId = new Guid("265a67cd-9040-43b4-ac4a-8e76c46d85fd"),
                            Skill_Name = "ASP.NET"
                        },
                        new
                        {
                            SkillId = new Guid("ada5ad61-71a4-459a-8494-7bdadba7fed4"),
                            Skill_Name = "Azure"
                        },
                        new
                        {
                            SkillId = new Guid("8ac2b3ce-f1e4-4d71-ad25-4aee93384e0a"),
                            Skill_Name = "AWS"
                        },
                        new
                        {
                            SkillId = new Guid("5dd912e7-2668-4210-8f18-e1b675199f7c"),
                            Skill_Name = "GCP"
                        },
                        new
                        {
                            SkillId = new Guid("ecbb456d-5759-4746-88ab-e6cf9b15ae90"),
                            Skill_Name = "SQL"
                        },
                        new
                        {
                            SkillId = new Guid("b9d92cce-f3cc-47f2-9181-c116bf6a09de"),
                            Skill_Name = "NoSQL"
                        },
                        new
                        {
                            SkillId = new Guid("86eb1e41-e46a-41b7-b249-72d40037e95d"),
                            Skill_Name = "Docker"
                        },
                        new
                        {
                            SkillId = new Guid("6cd69895-b90f-4c91-afc5-9db6f616d482"),
                            Skill_Name = "Kubernetes"
                        },
                        new
                        {
                            SkillId = new Guid("98c28ae6-6654-40f0-86f3-98d45deaf017"),
                            Skill_Name = "GraphQL"
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
                            TitleId = new Guid("51c7ec5f-3ddb-47ef-9cb8-dba1d4180940"),
                            TitleName = "Full Stack Developer"
                        },
                        new
                        {
                            TitleId = new Guid("1ebf82d2-974f-4630-bc0c-3632f8cb4847"),
                            TitleName = "Front End Developer"
                        },
                        new
                        {
                            TitleId = new Guid("99da2a06-ea51-47f7-adc1-5cf24a70e222"),
                            TitleName = "Back End Developer"
                        },
                        new
                        {
                            TitleId = new Guid("7bab2fdb-2807-4cd6-8914-efe3120da31a"),
                            TitleName = "Software Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("53deb86e-a904-4760-a824-85cf6ed39f91"),
                            TitleName = "Data Scientist"
                        },
                        new
                        {
                            TitleId = new Guid("9e59c86a-58d6-4659-a7e1-9fd0c60cc3a6"),
                            TitleName = "DevOps Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("cb0559ee-e156-4c4d-985b-13f3fc966725"),
                            TitleName = "Product Manager"
                        },
                        new
                        {
                            TitleId = new Guid("159d6de8-f85d-441f-a59a-76eab718494f"),
                            TitleName = "Project Manager"
                        },
                        new
                        {
                            TitleId = new Guid("3b6d0e62-2b2b-46f2-a108-38dd3d80f3e0"),
                            TitleName = "Business Analyst"
                        },
                        new
                        {
                            TitleId = new Guid("b2870e60-8c0d-4870-b0c7-45c7f7a5cd80"),
                            TitleName = "QA Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("e0a958c6-4d2b-41a0-80e5-c24c72e46a07"),
                            TitleName = "UI/UX Designer"
                        },
                        new
                        {
                            TitleId = new Guid("1ce78d42-c795-4cca-9b58-b2a9b6cb2ebd"),
                            TitleName = "Mobile Developer"
                        },
                        new
                        {
                            TitleId = new Guid("97a2b333-55a5-4357-9fd5-276c2ffbce6e"),
                            TitleName = "Security Analyst"
                        },
                        new
                        {
                            TitleId = new Guid("60a4e3ff-de49-47d4-8b5c-a69d4b6511d4"),
                            TitleName = "Network Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("4e8d8d9d-5a51-4f37-8404-9ed18f82135a"),
                            TitleName = "Systems Administrator"
                        },
                        new
                        {
                            TitleId = new Guid("d45e60de-f0b3-4891-8723-1ae53c58eaf4"),
                            TitleName = "Database Administrator"
                        },
                        new
                        {
                            TitleId = new Guid("a022d1a9-fc89-422b-a928-586678dbfac9"),
                            TitleName = "Cloud Architect"
                        },
                        new
                        {
                            TitleId = new Guid("49b1c0ba-4466-4850-89b3-ab798eda2c4d"),
                            TitleName = "Machine Learning Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("e78def9d-f7b2-47a1-8d24-5f83f6c78ff3"),
                            TitleName = "Artificial Intelligence Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("8bcd2b71-58dc-422c-808a-c77345cc6ea7"),
                            TitleName = "Technical Support Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("9243fdd6-a706-4187-ae8a-2e7de171278e"),
                            TitleName = "Cloud Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("e91031c0-1d21-49ab-85d3-0b356077792f"),
                            TitleName = "Database Developer"
                        },
                        new
                        {
                            TitleId = new Guid("ff51502d-acad-4f4b-ad2a-c1e53c89ca98"),
                            TitleName = "Blockchain Developer"
                        },
                        new
                        {
                            TitleId = new Guid("5f6798b5-d070-4f6c-b5e2-781e63f7f3b9"),
                            TitleName = "Game Developer"
                        },
                        new
                        {
                            TitleId = new Guid("dd1ddeb2-299c-42c7-b517-24edb0333ecf"),
                            TitleName = "VR/AR Developer"
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
                        .OnDelete(DeleteBehavior.Restrict)
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