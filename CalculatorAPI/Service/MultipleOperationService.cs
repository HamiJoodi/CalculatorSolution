namespace Calculator.Service
{
    public class MultipleOperationService : IOperationService
    {
        public double Operate(double Param1, double Param2)
        {
            return Param1 * Param2;
        }
    }
}
