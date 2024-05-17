
using Bisku.Persistence;

namespace Bisku.Services
{
	public class ProductService (ApplicationDbContext context): IProductService
	{
		private readonly ApplicationDbContext _context=context;
		public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken = default)
		{
			return await _context.Products.Include(x=>x.ProductOffers).AsNoTracking().ToListAsync();
		}

		public async Task<Product?> GetAsync(int id, CancellationToken cancellationToken = default)
		{
			return await _context.Products.FindAsync(id,cancellationToken);
		}

		public async Task<Product> AddAsync(Product product, CancellationToken cancellationToken = default)
		{
			await _context.Products.AddAsync(product,cancellationToken);
			await _context.SaveChangesAsync(cancellationToken);
			return product;
		}

		public async Task<bool> UpdateASync(int id, Product product, CancellationToken cancellationToken = default)
		{
			var currentProduct= await GetAsync(id,cancellationToken);
			if (currentProduct is null) return false;
				
			currentProduct.Name = product.Name;
			currentProduct.Details=product.Details;
			currentProduct.Price=product.Price;
			currentProduct.Quantity=product.Quantity;
			currentProduct.Image=product.Image;

			await _context.SaveChangesAsync(cancellationToken);
			return true;
		}

		public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
		{
			var product=await GetAsync(id,cancellationToken);
			if(product is null) return false;

			_context.Remove(product);
			await _context.SaveChangesAsync(cancellationToken);
			return true;
		}


		public async Task<bool> ToggleAvailableStatusAsync(int id, CancellationToken cancellationToken = default)
		{
			var product=await GetAsync(id,cancellationToken);
			if(product is null) return false;

			product.IsAvailable=!product.IsAvailable;
			await _context.SaveChangesAsync(cancellationToken);
			return true;

		}

	}
}
