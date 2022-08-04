using Exchange.Contract.Request.Query;
using FluentValidation;

namespace Exchange.Application.Validators
{
    public class GetTrancastionQueryValidator : AbstractValidator<GetTransactionsQuery>
    {
        public GetTrancastionQueryValidator()
        {
            RuleFor(c => c.AccountId).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
