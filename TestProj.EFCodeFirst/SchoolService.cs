
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.EFCodeFirst
{
    public class SchoolService
    {
        private SchoolContext _context;

        public SchoolService(SchoolContext context)
        {
            _context = context;
        }

        public Student AddStudent(string firstName, string lastName)
        {
            var blog = _context.Students.Add(new Student { FirstName = firstName, LastName = lastName });
            _context.SaveChanges();

            return blog;
        }

        public List<Student> GetAllStudents()
        {
            var query = from b in _context.Students
                        orderby b.LastName
                        select b;

            return query.ToList();
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var query = from b in _context.Students
                        orderby b.LastName
                        select b;

            return await query.ToListAsync();
        }
    }
}
