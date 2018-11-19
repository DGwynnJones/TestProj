
using Moq;
using NUnit.Framework;

namespace TestProj.Test
{
    [TestFixture]
    public class MoqExample
    {
        [Test]
        public void Basic_With_Interface()
        {
            var mock = new Mock<IDependency>();

            // WOW! No record/replay weirdness?! :)
            mock.Setup(framework => framework.DownloadExists("2.0.0.0")).Returns(true);

            // Use the Object property on the mock to get a reference to the object
            // implementing IDependency, and then exercise it by calling
            // methods on it
            IDependency dependentObject = mock.Object;

            //bool download = lovable.DownloadExists("2.0.0.0");
            //download = lovable.DownloadExists("2.0.0.0");
            //bool download = lovable.DownloadExists("9.0.0.0");

            var obj = new MyClass(dependentObject);

            // Verify that the given method was indeed called with the expected value at most once
            mock.Verify(framework => framework.DownloadExists("2.0.0.0"), Times.AtLeastOnce());
        }
    }

    public class MyClass
    {
        public IDependency Dependency { get; set; }

        public MyClass(IDependency dependency)
        {
            Dependency = dependency;

            // Must do this
            bool download = Dependency.DownloadExists("2.0.0.0");
        }
    }

    public interface IDependency
    {
        bool DownloadExists(string x);
    }
}
