using FluentValidation;

namespace Bisku.Contracts.Category
{
	public class CategoryRequestValidator : AbstractValidator<CategoryRequest>
	{
        public CategoryRequestValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x=>x.Details).NotEmpty().MaximumLength(500);
        }

    }
		
	
}
