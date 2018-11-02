
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestProj.EFCodeFirst
{
    public class Grade
    {
        public int GradeId { get; set; }

        public string GradeName { get; set; }

        [Required]
        public int? GradeValue { get; set; }

        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
