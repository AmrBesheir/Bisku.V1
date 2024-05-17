using FluentValidation;

namespace Bisku.Contracts.Product
{
	public class ProductRequestValidator :AbstractValidator<ProductRequest>
	{
        public ProductRequestValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().MaximumLength(150);
            RuleFor(x => x.Details).NotEmpty().MaximumLength(1500);
            RuleFor(x => x.Price).GreaterThan(0);
            RuleFor(x=>x.Quantity).GreaterThan(0);
         

        }

    }
}
