using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationResultDesignPattern
{
    public class Executor
    {
        public OperationResult Operation()
        {
            var randomNumber = new Random().Next(100);
            var success = randomNumber % 2 == 0;

            if (success)
            {
                return OperationResult.Success(randomNumber);
            }
            else
            {
                var error = new OperationResultMessage(
                    $"Something went wrong with the number '{randomNumber}'",
                    OperationResultSeverity.Error
                    );
                return OperationResult.Failure(error);
            }
        }
    }
}
