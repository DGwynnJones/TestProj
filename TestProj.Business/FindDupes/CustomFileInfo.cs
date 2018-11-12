using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TestProj.Business.FindDupes
{
    public class CustomFileInfo
    {
        public string FullName { get; set; }

        public IList<string> Locations { get; set; }

        public string Name { get; set; }

        public string Hash { get; set; }

        public long Size { get; set; }

        public CustomFileInfo(string filename)
        {
            Locations = new List<string>();

            var fi = new FileInfo(filename);
            FullName = fi.FullName;
            Name = fi.Name;
            Size = fi.Length;
            Hash = GetChecksum(FullName);
        }

        public static string GetChecksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("[{0}]", GetType().FullName));
            result.AppendLine("Name: " + Name);
            result.AppendLine("FullName: " + FullName);
            result.AppendLine("Size: " + Size);
            result.AppendLine("Hash: " + Hash);
            result.AppendLine("Locations:");

            foreach (var item in Locations)
            {
                result.AppendLine("    " + item);
            }

            return result.ToString();
        }
    }
}
