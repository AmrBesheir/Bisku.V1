
using Bisku.Persistence;

namespace Bisku.Services
{
	public class CategoryService(ApplicationDbContext context) : ICategoryService
	{
		private readonly ApplicationDbContext _context = context;
		public async Task<IEnumerable<Category>> GetAllAsync(CancellationToken cancellationToken = default)
		{
			return await _context.Categories.Include(x=>x.Products).AsNoTracking().ToListAsync(cancellationToken);
		}
		public async Task<Category?> GetAsync(int id, CancellationToken cancellationToken = default)
		{
			return await _context.Categories.FindAsync(id, cancellationToken);
		}
		public async Task<Category> AddAsync(Category Category, CancellationToken cancellationToken = default)
		{
			await _context.Categories.AddAsync(Category, cancellationToken);
			await _context.SaveChangesAsync(cancellationToken);
			return Category;
		}

		public async Task<bool> UpdateASync(int id, Category Category, CancellationToken cancellationToken = default)
		{
			var currentCategory=await GetAsync(id, cancellationToken);
			if(currentCategory is null) return false;

			currentCategory.Name= Category.Name;
			currentCategory.Details= Category.Details;

			await _context.SaveChangesAsync(cancellationToken);
		
			return true;
		}
		public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
		{
			var category = await GetAsync(id, cancellationToken);
			if (category is null)
				return false;

			 _context.Remove(category);
			await _context.SaveChangesAsync(cancellationToken);
			return true;
		}


		public async Task<bool> ToggleAvailableStatusAsync(int id, CancellationToken cancellationToken = default)
		{
			var category = await GetAsync(id, cancellationToken);
			if (category is null)
				return false;

			category.IsAvailable = !category.IsAvailable;
		    await _context.SaveChangesAsync(cancellationToken);
			return true;
		}
		public Task<bool> IsvalidCategory(int id,CancellationToken cancellationToken)
		{
			return _context.Categories.AnyAsync(g => g.Id == id);
		}


	}
}

