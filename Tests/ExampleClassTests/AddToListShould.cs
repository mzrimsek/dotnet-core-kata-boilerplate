using NUnit.Framework;
using Lib.ExampleProject;

namespace Tests.ExampleClassTests
{
    public class AddToListShould
    {
        private ExampleClass _exampleClass;

        [SetUp]
        public void BeforeEach()
        {
            _exampleClass = new ExampleClass();
        }

        [Test]
        public void HaveNumber()
        {
            var number = 6.5;
            _exampleClass.AddToList(number);

            var result = _exampleClass.GetList();

            Assert.That(result, Does.Contain(number));
        }
    }
}