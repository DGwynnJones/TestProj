using System;
using System.ComponentModel.DataAnnotations;

namespace TestProj.EFCodeFirst
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public string Remarks { get; set; }

        public Grade Grade { get; set; }
    }
}
