using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationResultDesignPattern
{
    public abstract record class OperationResult
    {
        private OperationResult()
        {

        }

        public abstract bool Succeded { get; }
        public static  OperationResult Success(int? value = null)
        {
            return new SuccessfulOperationResult { Value = value };
        }
        public static OperationResult Failure(params OperationResultMessage[] errors)
        {
            return new FailedOperationResult(errors);
        }
        private record class SuccessfulOperationResult:OperationResult
        {
            public override bool Succeded { get; } = true;
            public virtual int? Value { get; init; }
        }
        private record class FailedOperationResult : OperationResult
        {
            public FailedOperationResult(params OperationResultMessage[] errors)
            {
                Messages = errors.ToImmutableList();
            }
            public override bool Succeded { get; } = false;
            public ImmutableList<OperationResultMessage> Messages { get; }
        }

    }
}
