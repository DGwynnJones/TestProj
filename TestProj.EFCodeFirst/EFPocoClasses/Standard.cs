﻿
using System.Collections.Generic;

namespace TestProj.EFCodeFirst.EFPocoClasses
{
    public class Standard
    {
        public Standard()
        {
            Students = new List<Student>();
        }

        public int StandardId { get; set; }

        public string StandardName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}