using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace TestProj.Business.FindDupes
{
    public class FindDupes
    {
        private bool verbose = false;

        public enum ComparisonType
        {
            FilenameOnly,
            Content
        }

        public List<CustomFileInfo> DuplicateFiles { get; set; }
        public List<CustomFileInfo> SetA { get; set; }
        public List<CustomFileInfo> SetB { get; set; }

        //public FindDupes(string rootFolder)
        //{
        //}

        public FindDupes(string rootFolder1, string rootFolder2, string pattern)
        {
            var files1 = Directory.GetFiles(rootFolder1, pattern, SearchOption.AllDirectories).ToList();
            var files2 = Directory.GetFiles(rootFolder2, pattern, SearchOption.AllDirectories).ToList();

            var x = files1.Select(g => new CustomFileInfo(g));
            var y = files2.Select(g => new CustomFileInfo(g));

            SetA = x.ToList();
            SetB = y.ToList();

            DuplicateFiles = x.Intersect(y, new CustomFileInfoComparer()).ToList();

            var source = x.ToList();
            source.AddRange(y);

            foreach (var item in DuplicateFiles)
            {
                var www = source.Where(_ => _.Hash == item.Hash).ToList();

                if (www.Count > 1)
                {
                    Trace.WriteLineIf(verbose, "!!!!!!!!!!!!!!!");
                    foreach (var foundItem in www)
                    {
                        Trace.WriteLineIf(verbose, "");
                        Trace.WriteLineIf(verbose, foundItem.ToString());

                        item.Locations.Add(foundItem.FullName);
                    }
                    Trace.WriteLineIf(verbose, "!!!!!!!!!!!!!!!");
                    Trace.WriteLineIf(verbose, "");
                }
                else
                {
                    Trace.WriteLine("NO dupes found for " + item.Hash);
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("[{0}]", GetType().FullName));
            result.AppendLine("SetA: " + SetA.Count);
            result.AppendLine("SetB: " + SetB.Count);
            result.AppendLine("DuplicateFiles: " + DuplicateFiles.Count);

            return result.ToString();
        }
    }
}
