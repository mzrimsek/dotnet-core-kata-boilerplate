using NUnit.Framework;
using Lib.ExampleProject;

namespace Tests.ExampleStaticClassTests
{
    public class AddNumbersShould
    {
        [Test]
        public void Give3_WhenGiven1_And2()
        {
            var result = ExampleStaticClass.AddNumbers(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}