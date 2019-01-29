
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TestProj.EFCodeFirst
{
    public class SchoolModel
    {
        private SchoolContext _context;

        public SchoolModel()
        {
            _context = new SchoolContext();
        }

        public SchoolModel(SchoolContext context)
        {
            _context = context;
        }

        public Student AddStudent(string firstName, string lastName)
        {
            var blog = _context.Students.Add(new Student { FirstName = firstName, LastName = lastName });
            _context.SaveChanges();

            return blog;
        }

        public IList<Student> GetAllStudents()
        {
            var query = from b in _context.Students.Include(g => g.Grade)
                        orderby b.LastName
                        select b;

            return query.ToList();
        }

        public IList<Grade> GetAllGrades()
        {
            var query = from b in _context.Grades.Include(g => g.Students)
                        orderby b.GradeName
                        select b;

            return query.ToList();
        }

        //public async Task<List<Student>> GetAllStudentsAsync()
        //{
        //    var query = from b in _context.Students
        //                orderby b.LastName
        //                select b;

        //    return await query.ToListAsync();
        //}
    }
}
