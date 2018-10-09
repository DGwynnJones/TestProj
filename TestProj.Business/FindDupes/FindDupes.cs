using System.Collections.Generic;
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

            //var x = files1.Select(g => new CustomFileInfo(g)).ToList();
            //var y = files2.Select(g => new CustomFileInfo(g)).ToList();
            var x = files1.Select(g => new CustomFileInfo(g));
            var y = files2.Select(g => new CustomFileInfo(g));

            //var intersect = 
            //this.DuplicateFiles = files1.Select(i => i.ToString()).Intersect(files2).ToList();

            //var results = files1.Intersect(files2, StringComparer.OrdinalIgnoreCase).ToList();
            //var results = x.Intersect(y, StringComparer.OrdinalIgnoreCase).ToList();

            //var intersection = x.Where(q => y.Intersect(y, new CustomFileInfoComparer()).Any()).ToList();

            //var results = x.Join(y, o => o.Name, id => id, (o, id) => o);

            //var list3 = x.Intersect(y, new CustomFileInfoComparer<CustomFileInfo>());


            //IEnumerable<CustomFileInfo> duplicates = x.Intersect(y, new CustomFileInfoComparer());
            //var duplicates = x.Intersect(y, new CustomFileInfoComparer()).ToList();
            DuplicateFiles = x.Intersect(y, new CustomFileInfoComparer()).ToList();

        }


    }
}
