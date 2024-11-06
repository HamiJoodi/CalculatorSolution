namespace Calculator.Service
{
    public class AddOperationService : IOperationService
    {
        public double Operate(double Param1, double Param2)
        {
            return Param1 + Param2;
        }
    }
}
