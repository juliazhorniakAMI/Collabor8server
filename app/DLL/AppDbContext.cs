using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.DLL.Models;
using Microsoft.EntityFrameworkCore;


namespace app.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C8orProject>()
            .HasKey(m => new { m.UserId, m.SphereId, m.ProjectId });
            modelBuilder.Entity<C8orSkill>()
           .HasKey(m => new { m.UserId, m.SphereId, m.SkillId });
            modelBuilder.Entity<Collabor8or>()
           .HasKey(m => new { m.UserId, m.SphereId });
            modelBuilder.Entity<Founder>()
           .HasKey(m => new { m.UserId, m.ProjectId });
            modelBuilder.Entity<ProjectSkill>()
          .HasKey(m => new { m.SkillId, m.ProjectId });
            modelBuilder.Entity<SphereSkill>()
          .HasKey(m => new { m.SphereId, m.SkillId });
        }
        public DbSet<User> Users { get; set; }
        public DbSet<C8orProject> C8orsProjects { get; set; }
        public DbSet<C8orSkill> C8orSkills { get; set; }
        public DbSet<Collabor8or> Collabor8ors { get; set; }
        public DbSet<Founder> Founders { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectSkill> ProjectSkills { get; set; }
        public DbSet<Sphere> Spheres { get; set; }
        public DbSet<SphereSkill> SphereSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProjectSupportInfo> ProjectSupportInfo { get; set; }

    }
}