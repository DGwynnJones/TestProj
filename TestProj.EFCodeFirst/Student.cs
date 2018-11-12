using System;
using System.Text;
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

        public int CurrentGradeId { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("[{0}]", GetType().FullName));
            result.AppendLine(": " + this.FirstName);
            result.AppendLine(": " + this.LastName);
            result.AppendLine(": " + this.Height);
            result.AppendLine(": " + this.Grade);
            result.AppendLine(": " + this.Remarks);
            result.AppendLine(": " + this.DateOfBirth.GetValueOrDefault().ToLongDateString());
            result.AppendLine(": " + this.CurrentGradeId);

            return result.ToString();
        }



    }
}
