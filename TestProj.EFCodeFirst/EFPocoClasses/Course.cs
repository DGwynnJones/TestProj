﻿using System.Collections.Generic;

namespace TestProj.EFCodeFirst.EFPocoClasses
{
    public class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
