using System.Data.Entity;

namespace TestProj.EFCodeFirst
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public SchoolContext() : base()
        {
        }

        public SchoolContext(string nameOrConnectionString) : base(nameOrConnectionString) //base("Conn")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Student>()
                .HasRequired<Grade>(s => s.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey<int>(s => s.CurrentGradeId);
        }
    }
}
