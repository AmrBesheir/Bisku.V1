namespace Bisku.Services
{
	public interface IProductService
	{
		Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken = default);
		Task<Product?> GetAsync(int id, CancellationToken cancellationToken = default);
		Task<Product> AddAsync(Product product, CancellationToken cancellationToken = default);
		Task<bool> UpdateASync(int id, Product product, CancellationToken cancellationToken = default);
		Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
		Task<bool> ToggleAvailableStatusAsync(int id, CancellationToken cancellationToken = default);
		
	}
}
