
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestProj.EFCodeFirst
{
    public class Grade
    {
        public int GradeId { get; set; }

        [Required]
        public string GradeName { get; set; }

        [Required]
        public int? GradeValue { get; set; }

        [Required]
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
