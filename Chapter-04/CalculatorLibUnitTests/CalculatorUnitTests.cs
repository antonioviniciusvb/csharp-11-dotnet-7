namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            //arrange
            double a = 2;
            double b = 2;

            Calculator.Add(a, b);
        }
    }
}