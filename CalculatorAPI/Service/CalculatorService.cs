
namespace Calculator.Service
{
    public class CalculatorService : ICalculatorService
    {
        private readonly OperatorServiceFactory _operationFactory;

        public CalculatorService(OperatorServiceFactory operationFactory) 
        {
            _operationFactory = operationFactory;
        }

        public double DoCalculate(double param1, double param2, string operation)
        {
            IOperationService operationService = _operationFactory.GetOperationService(operation);
            var result = operationService.Operate(param1, param2);
            return result;
        }
    }
}
