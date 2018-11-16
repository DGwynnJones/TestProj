using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SA.Utilities.ExtensionMethods;

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

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("[{0}]", GetType().FullName));
            result.AppendLine("FirstName: " + FirstName);
            result.AppendLine("LastName: " + LastName);
            result.AppendLine("Height: " + Height);
            result.AppendLine("Remarks: " + Remarks);
            result.AppendLine("DateOfBirth: " + DateOfBirth.GetValueOrDefault().ToLongDateString());
            result.AppendLine("CurrentGradeId: " + CurrentGradeId);

            result.Append("Grade: ");
            if (Grade != null)
            {
                result.AppendLine(Grade.GradeName);
            }
            else
            {
                result.AppendLine("[null]");
            }

            var dm = DateModified;

            result.AppendLine("DateModified: " + dm.ToLongDateAndTime());
            //result.AppendLine("DateModified: " + dm.ToLongDateString() + " " + dm.ToLongTimeString());

            return result.ToString();
        }
    }
}
