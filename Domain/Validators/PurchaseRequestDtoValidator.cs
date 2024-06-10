using Coffee_Shop_application.Models;
using FluentValidation;

namespace Coffee_Shop_application.Domain.Validators
{
    public class PurchaseRequestDtoValidator : AbstractValidator<PurchaseRequestDto>
    {
        public PurchaseRequestDtoValidator()
        {
            RuleFor(x => x.ClientId).GreaterThan(0);
            RuleFor(x => x.CoffeesBought).GreaterThan(0);
        }
    }
}
