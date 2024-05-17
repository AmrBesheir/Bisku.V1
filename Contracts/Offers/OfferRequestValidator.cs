using Bisku.Contracts.Product;
using FluentValidation;

namespace Bisku.Contracts.Offers
{
	public class OfferRequestValidator : AbstractValidator<OfferRequest>
	{
		public OfferRequestValidator()
		{
			RuleFor(x => x.Details).NotEmpty().MaximumLength(1500);
			RuleFor(x => x.DiscountPercentage).NotEmpty();
			RuleFor(x => x.StartDate).NotEmpty().GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Today));
			RuleFor(x => x.EndDate).NotEmpty();
			RuleFor(x => x).Must(HasValidDates).
				WithName(nameof(OfferRequest.EndDate))
				.WithMessage("{PropertyName} should be greater than or equal start Date");

		}

		private bool HasValidDates(OfferRequest request)
		{
			return request.EndDate >= request.StartDate;

		}
	}
}
