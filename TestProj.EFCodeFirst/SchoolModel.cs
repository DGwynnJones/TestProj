
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestProj.EFCodeFirst.EFPocoClasses;

namespace TestProj.EFCodeFirst
{
    public class SchoolModel
    {
        public SchoolContext Context { get; private set; }

        public SchoolModel()
        {
            Context = new SchoolContext();
        }

        public SchoolModel(SchoolContext context)
        {
            Context = context;
        }

        public Student AddStudent(string firstName, string lastName)
        {
            var blog = Context.Students.Add(new Student { FirstName = firstName, LastName = lastName });
            Context.SaveChanges();

            return blog;
        }

        public IList<Student> GetAllStudents()
        {
            var query = from b in Context.Students.Include(g => g.Grade)
                        orderby b.LastName
                        select b;

            return query.ToList();
        }

        public IList<Grade> GetAllGrades()
        {
            var query = from b in Context.Grades.Include(g => g.Students)
                        orderby b.GradeName
                        select b;

            return query.ToList();
        }
    }
}
