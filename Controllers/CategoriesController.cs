namespace Bisku.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	
	public class CategoriesController(ICategoryService categoryService) : ControllerBase
	{
		private readonly ICategoryService _categoryService=categoryService;

		[HttpGet("")]
		public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
		{
			var categories= await _categoryService.GetAllAsync(cancellationToken);
			var response=categories.Adapt<IEnumerable<CategoryResponse>>();
			return Ok(response);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get([FromRoute] int id,CancellationToken cancellationToken)
		{
			var category=await _categoryService.GetAsync(id,cancellationToken);
			var response= category.Adapt<CategoryResponse>();
			if(category is null) return NotFound();
			return Ok(response);
		}
	
		[HttpPost("")]
		public async Task<IActionResult> AddAsync([FromBody] CategoryRequest request,CancellationToken cancellationToken)
		{
			var newCategory = await _categoryService.AddAsync(request.Adapt<Category>(), cancellationToken);

			return CreatedAtAction(nameof(Get), new {id=newCategory.Id},newCategory);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CategoryRequest request,CancellationToken cancellationToken)
		{
			var result = await _categoryService.UpdateASync(id, request.Adapt<Category>(), cancellationToken);
			if(!result)
				return NotFound();
			return NoContent();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken cancellationToken)
		{
			var result=await _categoryService.DeleteAsync(id, cancellationToken);
			if(!result) return NotFound();
			return NoContent();
		}

		[HttpPut("{id}/toggleAvailable")]
		public async Task<IActionResult> ToggleAvailable([FromRoute] int id, CancellationToken cancellationToken)
		{
			var result = await _categoryService.ToggleAvailableStatusAsync(id, cancellationToken);

			if (!result)
				return NotFound();

			return NoContent();
		}


	}
}
