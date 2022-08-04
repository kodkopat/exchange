using Exchange.Contract.Request.Query;
using FluentValidation;

namespace Exchange.Application.Validators
{
    public class GetRatesQueryValidator : AbstractValidator<GetRatesQuery>
    {
        public GetRatesQueryValidator()
        {
            RuleFor(c => c.Source).NotNull().NotEmpty().Length(3, 15);
            RuleFor(c => c.Destination).NotEmpty().NotNull().Must(x => x.Count > 0);
        }
    }
}
