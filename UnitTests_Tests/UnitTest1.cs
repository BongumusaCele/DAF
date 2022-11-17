using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace UnitTests_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ZeroPlusOne_ReturnsOne()
        {
            // arrange
            Calculator calculator = new Calculator();
            const int ZERO = 0;
            const int ONE = 1;
            // act
            int actual = calculator.Add(ZERO, ONE);
            // assert
            Assert.AreEqual(ONE, actual);
        }
    }
}
