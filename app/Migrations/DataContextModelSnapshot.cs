﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using app.Context;

#nullable disable

namespace app.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("app.DLL.Models.C8orAccepted4Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Collabor8orId")
                        .HasColumnType("integer");

                    b.Property<string>("Contracts")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Collabor8orId");

                    b.HasIndex("ProjectId");

                    b.ToTable("C8orsAccepted4Project");
                });

            modelBuilder.Entity("app.DLL.Models.C8orProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Collabor8orId")
                        .HasColumnType("integer");

                    b.Property<int>("Direction")
                        .HasColumnType("integer");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Collabor8orId");

                    b.HasIndex("ProjectId");

                    b.ToTable("C8orsProjects");
                });

            modelBuilder.Entity("app.DLL.Models.C8orSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("C8orId")
                        .HasColumnType("integer");

                    b.Property<int?>("Collabor8orId")
                        .HasColumnType("integer");

                    b.Property<int>("SkillId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Collabor8orId");

                    b.HasIndex("SkillId");

                    b.ToTable("C8orSkills");
                });

            modelBuilder.Entity("app.DLL.Models.Collabor8or", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BackgroundSummary")
                        .HasColumnType("text");

                    b.Property<string>("Resume")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Collabor8ors");
                });

            modelBuilder.Entity("app.DLL.Models.Founder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BackgroundSummary")
                        .HasColumnType("text");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<string>("Resume")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Founders");
                });

            modelBuilder.Entity("app.DLL.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ideas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("app.DLL.Models.ProjectSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<int>("SkillId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SkillId");

                    b.ToTable("ProjectSkills");
                });

            modelBuilder.Entity("app.DLL.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("app.DLL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("app.DLL.Models.C8orAccepted4Project", b =>
                {
                    b.HasOne("app.DLL.Models.Collabor8or", "Collabor8or")
                        .WithMany("C8orAccepted4Project")
                        .HasForeignKey("Collabor8orId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.Project", "Project")
                        .WithMany("C8orAccepted4Project")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collabor8or");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("app.DLL.Models.C8orProject", b =>
                {
                    b.HasOne("app.DLL.Models.Collabor8or", "Collabor8or")
                        .WithMany("C8orsProjects")
                        .HasForeignKey("Collabor8orId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("app.DLL.Models.Project", "Project")
                        .WithMany("C8orsProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collabor8or");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("app.DLL.Models.C8orSkill", b =>
                {
                    b.HasOne("app.DLL.Models.Collabor8or", "Collabor8or")
                        .WithMany("C8orSkill")
                        .HasForeignKey("Collabor8orId");

                    b.HasOne("app.DLL.Models.Skill", "Skill")
                        .WithMany("C8orSkill")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collabor8or");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("app.DLL.Models.Collabor8or", b =>
                {
                    b.HasOne("app.DLL.Models.User", "User")
                        .WithMany("Collabor8ors")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("app.DLL.Models.Collabor8or", b =>
                {
                    b.Navigation("C8orAccepted4Project");

                    b.Navigation("C8orSkill");

                    b.Navigation("C8orsProjects");
                });

            modelBuilder.Entity("app.DLL.Models.Project", b =>
                {
                    b.Navigation("C8orAccepted4Project");

                    b.Navigation("C8orsProjects");

                    b.Navigation("Founders");

                    b.Navigation("ProjectSkill");
                });

            modelBuilder.Entity("app.DLL.Models.Skill", b =>
                {
                    b.Navigation("C8orSkill");

                    b.Navigation("ProjectSkill");
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
