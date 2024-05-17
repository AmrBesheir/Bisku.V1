namespace Bisku.Services
{
	public interface IOfferService
	{
		Task<IEnumerable<Offer>> GetAllOffersAsync(CancellationToken cancellationToken = default);
		Task<Offer?> GetOfferAsync(int id,CancellationToken cancellationToken=default);
		Task<Offer> AddAsync(Offer offer,CancellationToken cancellationToken=default);
		Task<bool> UpdateAsync(int id, Offer offer,CancellationToken cancellationToken=default);
		Task<bool> DeleteAsync(int id,CancellationToken cancellationToken=default);
		Task<bool> ToggleAvailableStatusAsync(int id, CancellationToken cancellationToken = default);

	}
}
