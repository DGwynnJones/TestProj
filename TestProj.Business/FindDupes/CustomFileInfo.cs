using System.IO;

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

    }
}
