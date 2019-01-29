
using SA.Utilities.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestProj.EFCodeFirst.EFPocoClasses
{
    public class Student
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        [Required]
        public virtual StudentAddress Address { get; set; }

        public int AddressId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public int CurrentGradeId { get; set; }

        [Required]
        public DateTime? DateModified { get; set; } = DateTime.Now;

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string FirstName { get; set; }

        //[Required]
        public Grade Grade { get; set; }

        public decimal Height { get; set; }

        [Required]
        public string LastName { get; set; }

        public byte[] Photo { get; set; }

        public string PreferredName { get; set; }

        public string Remarks { get; set; }

        public virtual Standard Standard { get; set; }

        public int StudentID { get; set; }

        public float Weight { get; set; }

        public override string ToString()
        {
            return this.GenericToString();
        }
    }
}
