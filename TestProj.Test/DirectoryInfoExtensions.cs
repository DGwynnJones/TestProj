using System.IO;

namespace TestProj.Test
{
    public static class DirectoryInfoExtensions
    {
        public static string GetFilename(this DirectoryInfo directoryInfo, string filename)
        {
            return Path.Combine(directoryInfo.FullName, filename);
        }
    }
}
