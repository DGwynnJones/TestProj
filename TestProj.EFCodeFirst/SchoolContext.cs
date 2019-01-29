using System.Data.Entity;
using TestProj.EFCodeFirst.EFPocoClasses;

namespace TestProj.EFCodeFirst
{
    public class SchoolContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }

        private static string _dbName = "TestProj.EFCodeFirst.SchoolContext";

        public SchoolContext() : base(_dbName)
        {
        }

        internal SchoolContext(string nameOrConnectionString) : base(nameOrConnectionString) //base("Conn")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            //modelBuilder.Entity<Student>()
            //    .HasRequired<Grade>(s => s.Grade)
            //    .WithMany(g => g.Students)
            //    .HasForeignKey<int>(s => s.CurrentGradeId);

            modelBuilder.Entity<Student>()
                .HasRequired<StudentAddress>(s => s.Address);
        }
    }
}
