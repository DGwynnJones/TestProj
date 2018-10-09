using System.Collections.Generic;

namespace TestProj.Business.FindDupes
{
    public class CustomFileInfoComparer : IEqualityComparer<CustomFileInfo>
    {
        public bool Equals(CustomFileInfo x, CustomFileInfo y)
        {
            // TODO - Add null handling.
            return x.Name == y.Name && x.Size == y.Size;
        }

        public int GetHashCode(CustomFileInfo obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
