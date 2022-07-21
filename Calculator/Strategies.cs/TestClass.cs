namespace Calculator 
{
    public class TestClass
    {
        public void Test()
        {
            IArithmeticOperation operation = new AddStrategy();
            Calculator calculator = new Calculator(operation);
            double result = calculator.Compute(5, 4);
        }
    }
}