using NUnit.Framework;

namespace TestProj.Test
{
    [TestFixture]
    public class BasicTests
    {

        [Test]
        public void Basic_1()
        {
            var result = TestProj.Business.ClassUnderTest.GetAnswer("Bob");

            Assert.That(result, Is.EqualTo("Hello Bob"));

        }

    }
}
