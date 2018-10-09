using System.IO;
using System.Text;

namespace TestProj.Business.FindDupes
{
    public class CustomFileInfo
    {
        public string FullName { get; set; }

        public string Name { get; set; }

        public long Size { get; set; }

        public CustomFileInfo(string filename)
        {
            var fi = new FileInfo(filename);
            this.FullName = fi.FullName;
            this.Name = fi.Name;
            this.Size = fi.Length;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("[{0}]", this.GetType().FullName));
            result.AppendLine("Name: " + this.Name);
            result.AppendLine("FullName: " + this.FullName);
            result.AppendLine("Size: " + this.Size);

            return result.ToString();
        }

    }
}
