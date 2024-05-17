namespace Bisku.Contracts.Offers
{
	public record OfferRequest(
		string Details,
		decimal DiscountPercentage,
		DateOnly StartDate,
		DateOnly EndDate
		);
	
}
