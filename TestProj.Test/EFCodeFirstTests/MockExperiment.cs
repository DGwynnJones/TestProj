using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TestProj.EFCodeFirst;
using TestProj.EFCodeFirst.EFPocoClasses;

namespace TestProj.Test.EFCodeFirstTests
{
    [TestFixture]
    public class MockExperiment
    {
        [Test]
        public void GetAllBlogs_orders_by_name()
        {
            var data = new List<Student>
            {
                new Student { FirstName = "Bob" },
                new Student { FirstName = "Julia" },
                new Student { FirstName = "Mary" },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Student>>();

            mockSet.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<SchoolContext>();
            mockContext.Setup(c => c.Students).Returns(mockSet.Object);

            var service = new SchoolModel(mockContext.Object);
            var blogs = service.GetAllStudents();

            Assert.AreEqual(3, blogs.Count);
            Assert.AreEqual("Bob", blogs[0].FirstName);
            Assert.AreEqual("Julia", blogs[1].FirstName);
            Assert.AreEqual("Mary", blogs[2].FirstName);
        }
    }
}
