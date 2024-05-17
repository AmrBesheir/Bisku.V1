namespace Bisku.Contracts.Product
{
	public record ProductResponse(
		int Id,
		string Name,
		string Details,
		decimal Price,
		int Quantity,
		byte[] Image,
		bool IsAvailable,
		string OfferDetails
		);
	
}
