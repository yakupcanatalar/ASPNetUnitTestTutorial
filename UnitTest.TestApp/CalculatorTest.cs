using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTest.App;

namespace UnitTest.TestApp
{
    [TestClass]
    public class CalculatorTest
    {
        public Calculator calculator { get; set; }
        public Mock<ICalculatorService> mymock { get; set; }

        public CalculatorTest()
        {
            mymock = new Mock<ICalculatorService>();
            this.calculator = new Calculator(mymock.Object);

        }

        public void AddData()
        {
            mymock.Setup(t => t.Add(3, 5)).Returns(8);
        }
    }
}
