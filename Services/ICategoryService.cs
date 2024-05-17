namespace Bisku.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> GetAllAsync(CancellationToken cancellationToken = default);
		Task<Category?> GetAsync(int id, CancellationToken cancellationToken = default);
		Task<Category> AddAsync(Category Category, CancellationToken cancellationToken = default);
		Task<bool> UpdateASync(int id, Category Category, CancellationToken cancellationToken = default);
		Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
		Task<bool> ToggleAvailableStatusAsync(int id, CancellationToken cancellationToken = default);
		Task<bool> IsvalidCategory(int id, CancellationToken cancellationToken = default);

	}
}
