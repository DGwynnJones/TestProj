using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace TestProj.Business.FindDupes
{
    public class FindDupes
    {
        public List<CustomFileInfo> DuplicateFiles { get; set; }

        public enum ComparisonType
        {
            FilenameOnly,
            Content
        }

        //public FindDupes(string rootFolder)
        //{

        //}

        public FindDupes(string rootFolder1, string rootFolder2, string pattern)
        {
            var files1 = Directory.GetFiles(rootFolder1, pattern, SearchOption.AllDirectories).ToList();
            var files2 = Directory.GetFiles(rootFolder2, pattern, SearchOption.AllDirectories).ToList();

            var x = files1.Select(g => new CustomFileInfo(g));
            var y = files2.Select(g => new CustomFileInfo(g));

            DuplicateFiles = x.Intersect(y, new CustomFileInfoComparer()).ToList();

            var source = y.ToList();

            foreach (var item in DuplicateFiles)
            {
                var www = source.Where(_ => _.Hash == item.Hash).ToList();

                if (www.Count > 1)
                {

                    Trace.WriteLine("***********");
                    foreach (var foundItem in www)
                    {
                        Trace.WriteLine("");
                        Trace.WriteLine(foundItem.ToString());
                    }
                    Trace.WriteLine("***********");
                    Trace.WriteLine("");
                }
            }

            // var duplicateFiles2 = y.Intersect(x, new CustomFileInfoComparer()).ToList();

        }


    }
}
