using FizzBuzz.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Should_Return_Fizz_When_Input_Is_Multiple_Of_3()
        {
            var service = new FizzBuzzService();

            Assert.AreEqual("Fizz", service.SolveFizzBuzz(3));
        }
    }
}