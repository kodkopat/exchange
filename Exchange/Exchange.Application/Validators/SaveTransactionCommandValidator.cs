using Exchange.Contract.Request.Command;
using Exchange.Contract.Request.Query;
using FluentValidation;

namespace Exchange.Application.Validators
{
    public class SaveTransactionCommandValidator : AbstractValidator<SaveTransactionCommand>
    {
        public SaveTransactionCommandValidator()
        {
            RuleFor(c => c.Source).NotNull().NotEmpty().Length(3, 15);
            RuleFor(c => c.Destination).NotEmpty().NotNull().Must(x => x.Count > 0);
            RuleFor(c => c.SourceAmount).NotNull().GreaterThan(0);
            RuleFor(c => c.AccountId).NotNull().GreaterThan(0);
        }
    }
}
