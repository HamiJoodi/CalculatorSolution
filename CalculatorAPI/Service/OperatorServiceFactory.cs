using Microsoft.OpenApi.Models;

namespace Calculator.Service
{
    public class OperatorServiceFactory
    {
        public IOperationService GetOperationService(string operation)
        {
            switch (operation)
            {
                case "+":
                    return new AddOperationService();
                    break;
                case "-":
                    return new MinusOperationService();
                    break;
                case "*":
                    return new MultipleOperationService();
                    break;
                case "/":
                    return new DevidOperationService();
                    break;
                default:
                    throw new InvalidOperationException("not valid operation");
            }
        }
    }
}
