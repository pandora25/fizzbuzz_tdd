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

        [TestMethod]
        public void Should_Return_Buzz_When_Input_Is_Multiple_Of_5()
        {
            var service = new FizzBuzzService();

            Assert.AreEqual("Buzz", service.SolveFizzBuzz(5));
        }

        [TestMethod]
        public void Should_Return_FizzBuzz_When_Input_Is_Multiple_Of_Both_3_And_5()
        {
            var service = new FizzBuzzService();

            Assert.AreEqual("FizzBuzz", service.SolveFizzBuzz(15));
        }

        [TestMethod]
        public void Should_Return_Same_Input_When_Input_Is_Not_A_Multiple_Of_Either_3_Or_5()
        {
            var service = new FizzBuzzService();

            Assert.AreEqual("1", service.SolveFizzBuzz(1));
        }
    }
}