
namespace Bisku.Services
{
	public class OfferService( ApplicationDbContext context): IOfferService
	{ 
		private readonly ApplicationDbContext _context=context;


		public async Task<IEnumerable<Offer>> GetAllOffersAsync(CancellationToken cancellationToken = default)
		{
			return await _context.Offers.AsNoTracking().ToListAsync();
		}
		public async Task<Offer?> GetOfferAsync(int id, CancellationToken cancellationToken = default)
		{
		 return	await _context.Offers.FindAsync(id, cancellationToken);
		}

		public async Task<Offer> AddAsync(Offer offer, CancellationToken cancellationToken = default)
		{
			await _context.Offers.AddAsync(offer, cancellationToken);
			await _context.SaveChangesAsync(cancellationToken);
			return offer;
			
		}
		public async Task<bool> UpdateAsync(int id, Offer offer, CancellationToken cancellationToken = default)
		{
			var currentOffer = await GetOfferAsync(id, cancellationToken);
			if (currentOffer is null)
				return false;

			currentOffer.Details = offer.Details;
			currentOffer.DiscountPercentage = offer.DiscountPercentage;
			currentOffer.StartDate = offer.StartDate;
			currentOffer.EndDate = offer.EndDate;

			await _context.SaveChangesAsync(cancellationToken);

			return true;
		}

		public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
		{
			var offer = await GetOfferAsync(id, cancellationToken);
			if (offer is null)
				return false;

			_context.Remove(offer);
			_context.SaveChangesAsync(cancellationToken);
			return true;
		}

		

		public async Task<bool> ToggleAvailableStatusAsync(int id, CancellationToken cancellationToken = default)
		{
			var offer = await GetOfferAsync(id, cancellationToken);
			if (offer is null)
				return false;

			offer.IsAvialable = !offer.IsAvialable;
			await _context.SaveChangesAsync(cancellationToken);
			return true;
		}


	}
}
