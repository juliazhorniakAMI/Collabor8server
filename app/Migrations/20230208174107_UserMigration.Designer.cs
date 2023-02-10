﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using app.Context;

#nullable disable

namespace app.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230208174107_UserMigration")]
    partial class UserMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("app.DLL.Models.C8orProject", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("SphereId")
                        .HasColumnType("text");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<string>("AgreementURL")
                        .HasColumnType("text");

                    b.Property<int>("Direction")
                        .HasColumnType("integer");

                    b.Property<string>("ProposedURL")
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "SphereId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("C8orsProjects");
                });

            modelBuilder.Entity("app.DLL.Models.C8orSkill", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("SphereId")
                        .HasColumnType("text");

                    b.Property<string>("SkillId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "SphereId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("C8orSkills");
                });

            modelBuilder.Entity("app.DLL.Models.Collabor8or", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("SphereId")
                        .HasColumnType("text");

                    b.Property<string>("BackgroundSummary")
                        .HasColumnType("text");

                    b.Property<string>("Resume")
                        .HasColumnType("text");

                    b.HasKey("UserId", "SphereId");

                    b.HasIndex("SphereId");

                    b.ToTable("Collabor8ors");
                });

            modelBuilder.Entity("app.DLL.Models.Founder", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<string>("BackgroundSummary")
                        .HasColumnType("text");

                    b.Property<string>("Resume")
                        .HasColumnType("text");

                    b.HasKey("UserId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Founders");
                });

            modelBuilder.Entity("app.DLL.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SphereId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SphereId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("app.DLL.Models.ProjectSkill", b =>
                {
                    b.Property<string>("SkillId")
                        .HasColumnType("text");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.HasKey("SkillId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectSkills");
                });

            modelBuilder.Entity("app.DLL.Models.ProjectSupportInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Idea")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectSupportInfo");
                });

            modelBuilder.Entity("app.DLL.Models.Skill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("app.DLL.Models.Sphere", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Spheres");
                });

            modelBuilder.Entity("app.DLL.Models.SphereSkill", b =>
                {
                    b.Property<string>("SphereId")
                        .HasColumnType("text");

                    b.Property<string>("SkillId")
                        .HasColumnType("text");

                    b.HasKey("SphereId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("SphereSkills");
                });

            modelBuilder.Entity("app.DLL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("app.DLL.Models.C8orProject", b =>
                {
                    b.HasOne("app.DLL.Models.Project", "Project")
                        .WithMany("C8orsProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.Collabor8or", "Collabor8or")
                        .WithMany("C8orsProjects")
                        .HasForeignKey("UserId", "SphereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collabor8or");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("app.DLL.Models.C8orSkill", b =>
                {
                    b.HasOne("app.DLL.Models.Skill", "Skill")
                        .WithMany("C8orSkill")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.Collabor8or", "Collabor8or")
                        .WithMany("C8orSkill")
                        .HasForeignKey("UserId", "SphereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collabor8or");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("app.DLL.Models.Collabor8or", b =>
                {
                    b.HasOne("app.DLL.Models.Sphere", "Sphere")
                        .WithMany("Collabor8ors")
                        .HasForeignKey("SphereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.User", "User")
                        .WithMany("Collabor8ors")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sphere");

                    b.Navigation("User");
                });

            modelBuilder.Entity("app.DLL.Models.Founder", b =>
                {
                    b.HasOne("app.DLL.Models.Project", "Project")
                        .WithMany("Founders")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.User", "User")
                        .WithMany("Founders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("app.DLL.Models.Project", b =>
                {
                    b.HasOne("app.DLL.Models.Sphere", "Sphere")
                        .WithMany("Projects")
                        .HasForeignKey("SphereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sphere");
                });

            modelBuilder.Entity("app.DLL.Models.ProjectSkill", b =>
                {
                    b.HasOne("app.DLL.Models.Project", "Project")
                        .WithMany("ProjectSkill")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.Skill", "Skill")
                        .WithMany("ProjectSkill")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("app.DLL.Models.ProjectSupportInfo", b =>
                {
                    b.HasOne("app.DLL.Models.Project", "Project")
                        .WithMany("ProjectSupportInfo")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("app.DLL.Models.SphereSkill", b =>
                {
                    b.HasOne("app.DLL.Models.Skill", "Skill")
                        .WithMany("SphereSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.Sphere", "Sphere")
                        .WithMany("SphereSkills")
                        .HasForeignKey("SphereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("Sphere");
                });

            modelBuilder.Entity("app.DLL.Models.Collabor8or", b =>
                {
                    b.Navigation("C8orSkill");

                    b.Navigation("C8orsProjects");
                });

            modelBuilder.Entity("app.DLL.Models.Project", b =>
                {
                    b.Navigation("C8orsProjects");

                    b.Navigation("Founders");

                    b.Navigation("ProjectSkill");

                    b.Navigation("ProjectSupportInfo");
                });

            modelBuilder.Entity("app.DLL.Models.Skill", b =>
                {
                    b.Navigation("C8orSkill");

                    b.Navigation("ProjectSkill");

                    b.Navigation("SphereSkills");
                });

            modelBuilder.Entity("app.DLL.Models.Sphere", b =>
                {
                    b.Navigation("Collabor8ors");

                    b.Navigation("Projects");

                    b.Navigation("SphereSkills");
                });

            modelBuilder.Entity("app.DLL.Models.User", b =>
                {
                    b.Navigation("Collabor8ors");

                    b.Navigation("Founders");
                });
#pragma warning restore 612, 618
        }
    }
}
