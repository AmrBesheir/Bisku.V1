namespace Bisku.Contracts.Product
{
	public record ProductRequest(
		string Name,
		string Details,
		decimal Price,
		int Quantity,
		IFormFile? Image,
		bool IsAvailable,
		int CategoryId
		);

}
