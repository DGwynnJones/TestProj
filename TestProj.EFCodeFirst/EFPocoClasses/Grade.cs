﻿
using SA.Utilities.ExtensionMethods;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestProj.EFCodeFirst.EFPocoClasses
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

        public override string ToString()
        {
            return this.GenericToString();
        }
    }
}
