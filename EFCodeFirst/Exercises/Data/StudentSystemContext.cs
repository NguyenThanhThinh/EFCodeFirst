using Exercises.Migrations;
using Exercises.Models;
using System.Data.Entity;

namespace Exercises.Data
{
    public class StudentSystemContext:DbContext
    {
        public StudentSystemContext() : base("StudentSystemContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Cource> Cources { get; set; }

        public virtual DbSet<Resource> Resources { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }
    }
}
