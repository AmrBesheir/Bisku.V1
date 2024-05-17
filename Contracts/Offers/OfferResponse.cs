namespace Bisku.Contracts.Offers
{
	public record OfferResponse(
		string Details,
		decimal DiscountPercentage,
		DateOnly StartDate,
		DateOnly EndDate,
		bool IsAvialable
		);
	
}
