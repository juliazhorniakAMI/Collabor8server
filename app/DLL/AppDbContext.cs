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
        public DbSet<User> Users { get; set; }
        public DbSet<C8orAccepted4Project> C8orsAccepted4Project { get; set; }
        public DbSet<C8orProject> C8orsProjects { get; set; }
        public DbSet<C8orSkill> C8orSkills { get; set; }
        public DbSet<Collabor8or> Collabor8ors { get; set; }
        public DbSet<Founder> Founders { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectSkill> ProjectSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
       
    }
}