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
    [Migration("20240527041859_init")]
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
                            SkillId = new Guid("2526bc61-baf0-4967-bc8d-6eb1c29a09f1"),
                            Skill_Name = "HTML"
                        },
                        new
                        {
                            SkillId = new Guid("2c86b77a-9150-4c33-85ed-cae9b3e894c4"),
                            Skill_Name = "CSS"
                        },
                        new
                        {
                            SkillId = new Guid("7e86c3cb-d4d4-4bfd-bd32-913abebdc7f3"),
                            Skill_Name = "JavaScript"
                        },
                        new
                        {
                            SkillId = new Guid("ae40ece8-3233-402d-8267-ef8e0f52b089"),
                            Skill_Name = "TypeScript"
                        },
                        new
                        {
                            SkillId = new Guid("2d7146d7-65a8-42b9-8740-99f9f27e8847"),
                            Skill_Name = "React"
                        },
                        new
                        {
                            SkillId = new Guid("ce34c9b7-f2d9-49fa-9c10-bdb96bf1314a"),
                            Skill_Name = "Angular"
                        },
                        new
                        {
                            SkillId = new Guid("e5b38f78-4a12-4443-946a-70531569bb99"),
                            Skill_Name = "Vue"
                        },
                        new
                        {
                            SkillId = new Guid("c3ef6e93-dc34-4e08-9002-7581d2b07f79"),
                            Skill_Name = "Node.js"
                        },
                        new
                        {
                            SkillId = new Guid("b0d31ed4-37f9-4485-a6c0-099e3441ffcf"),
                            Skill_Name = "Express"
                        },
                        new
                        {
                            SkillId = new Guid("2b03cf51-f5c0-4ee3-86b8-006fd56dacaf"),
                            Skill_Name = "Python"
                        },
                        new
                        {
                            SkillId = new Guid("8469f12b-b536-4eac-8385-419019e4f193"),
                            Skill_Name = "Django"
                        },
                        new
                        {
                            SkillId = new Guid("464144c0-4edd-4cf2-869b-ac3f6fe5c034"),
                            Skill_Name = "Flask"
                        },
                        new
                        {
                            SkillId = new Guid("50b98280-d10d-458c-9f4b-de2f9b9e5a6c"),
                            Skill_Name = "Java"
                        },
                        new
                        {
                            SkillId = new Guid("fa773613-a5ce-4ac5-becc-a05c3e834bf7"),
                            Skill_Name = "Spring"
                        },
                        new
                        {
                            SkillId = new Guid("7034e518-b7e0-4513-bc0a-5dbb56227f96"),
                            Skill_Name = "Kotlin"
                        },
                        new
                        {
                            SkillId = new Guid("39843a19-7512-48c8-938a-e4b8f06443e1"),
                            Skill_Name = "Swift"
                        },
                        new
                        {
                            SkillId = new Guid("33997147-d435-47f1-99a2-17d09faf04a2"),
                            Skill_Name = "Objective-C"
                        },
                        new
                        {
                            SkillId = new Guid("6d71f71e-88a1-4e7b-b8d7-30dbd5de280d"),
                            Skill_Name = "Ruby"
                        },
                        new
                        {
                            SkillId = new Guid("61d8bcc3-dc94-4b98-8cbe-f89249354ae5"),
                            Skill_Name = "Rails"
                        },
                        new
                        {
                            SkillId = new Guid("a5252b60-ce57-4a03-bb3d-b057ab5378f3"),
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
                            TitleId = new Guid("50b3d904-fc8b-483a-8352-d643e80fc21e"),
                            TitleName = "Full Stack Developer"
                        },
                        new
                        {
                            TitleId = new Guid("1ade1a82-2a68-4420-8e1c-c8b0a6050fd1"),
                            TitleName = "Front End Developer"
                        },
                        new
                        {
                            TitleId = new Guid("360dd497-0e6f-407c-9c8b-06641d1c47f5"),
                            TitleName = "Back End Developer"
                        },
                        new
                        {
                            TitleId = new Guid("64b23c44-30aa-4841-877a-4c91bb32968f"),
                            TitleName = "Software Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("31cf9311-1fcd-42ea-b45b-18380200268a"),
                            TitleName = "Data Scientist"
                        },
                        new
                        {
                            TitleId = new Guid("fc74ccad-6572-4f48-88f4-66d7a1494029"),
                            TitleName = "DevOps Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("48312c0f-5673-473a-94bd-404db60c4d1b"),
                            TitleName = "Product Manager"
                        },
                        new
                        {
                            TitleId = new Guid("abfdbb40-e2ee-41bd-b893-672823312c61"),
                            TitleName = "Project Manager"
                        },
                        new
                        {
                            TitleId = new Guid("eaa9d01a-dc86-4c88-87d0-0315187f769f"),
                            TitleName = "Business Analyst"
                        },
                        new
                        {
                            TitleId = new Guid("7a2b6cbd-458e-492d-b908-28a8372977e5"),
                            TitleName = "QA Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("08bbd7d2-f1fc-4eae-b6ea-a75e6e274900"),
                            TitleName = "UI/UX Designer"
                        },
                        new
                        {
                            TitleId = new Guid("561be5cb-18ef-477f-a5dc-37d7d5999f44"),
                            TitleName = "Mobile Developer"
                        },
                        new
                        {
                            TitleId = new Guid("6440c0cc-bd9e-4f3f-8756-a971dd82707e"),
                            TitleName = "Security Analyst"
                        },
                        new
                        {
                            TitleId = new Guid("420de26a-2738-4596-aa25-e78e3cf7e395"),
                            TitleName = "Network Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("9fba039e-545d-4023-9028-0ae453c9c872"),
                            TitleName = "Systems Administrator"
                        },
                        new
                        {
                            TitleId = new Guid("429966cc-4c72-4516-94de-0779ab938ee6"),
                            TitleName = "Database Administrator"
                        },
                        new
                        {
                            TitleId = new Guid("b51c6d58-2b3f-4ba6-a047-9b4b3ae044a2"),
                            TitleName = "Cloud Architect"
                        },
                        new
                        {
                            TitleId = new Guid("c10e5444-3258-4c0e-ab87-24a0709b6419"),
                            TitleName = "Machine Learning Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("92d4a0a7-67c5-4a1c-b5cf-caaf03e99d7a"),
                            TitleName = "Artificial Intelligence Engineer"
                        },
                        new
                        {
                            TitleId = new Guid("412db0e1-5720-4f34-b6bb-9179f41d7e49"),
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