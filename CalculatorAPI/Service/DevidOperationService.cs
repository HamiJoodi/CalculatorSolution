namespace Calculator.Service
{
    public class DevidOperationService : IOperationService
    {
        public double Operate(double Param1, double Param2)
        {
            if (Param2 == 0)
                throw new Exception("second parameter can not be zero");

            return Param1/ Param2;
        }
    }
}
