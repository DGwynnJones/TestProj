﻿
using SA.Utilities.ExtensionMethods;
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

        [Required]
        public DateTime? DateModified { get; set; } = DateTime.Now;

        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public string Remarks { get; set; }
        public string PreferredName { get; set; }

        public Grade Grade { get; set; }

        public int CurrentGradeId { get; set; }

        public virtual StudentAddress Address { get; set; }

        public override string ToString()
        {
            return this.GenericToString();
        }
    }
}
