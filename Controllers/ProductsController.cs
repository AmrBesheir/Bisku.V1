using Bisku.Contracts.Product;
using Bisku.Services;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Bisku.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController(IProductService productService, ICategoryService categoryService) : ControllerBase
	{
		private readonly IProductService _productService = productService;
		private readonly ICategoryService _categoryService = categoryService;
		private new List<string> _allowedExtenstions = new List<string> { ".jpg", ".png" };
		private long _maxAllowedPosterSize = 1048576;


		[HttpGet("")]
		public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
		{
			var products = await _productService.GetAllAsync(cancellationToken);
			var response = products.Adapt<IEnumerable<ProductResponse>>();
			return Ok(response);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Get([FromRoute] int id, CancellationToken cancellationToken)
		{
			var product = await _productService.GetAsync(id);
			if (product is null) return NotFound();

			var response = product.Adapt<ProductResponse>();
			return Ok(response);
		}
		[HttpPost("")]
		public async Task<IActionResult> Add([FromForm] ProductRequest request, CancellationToken cancellationToken)
		{
			if (request.Image is null) return BadRequest("Product Image is required");

			if (!_allowedExtenstions.Contains(Path.GetExtension(request.Image.FileName).ToLower()))
				return BadRequest("Only .png and .jpg images are allowed!");


			if (request.Image.Length > _maxAllowedPosterSize)
				return BadRequest("Max allowed size for poster is 1MB!");

			var isVaildCategory = await _categoryService.IsvalidCategory(request.CategoryId, cancellationToken);
			if (!isVaildCategory) return BadRequest(" Invalid category ID !");
			var product = new Product();
			using var dataStream = new MemoryStream();
			await request.Image.CopyToAsync(dataStream);
		
			product.Name = request.Name;
			product.Details= request.Details;
			product.Image=dataStream.ToArray();
			product.IsAvailable= request.IsAvailable;
			product.Quantity= request.Quantity;
			product.Price= request.Price;
			product.CategoryId= request.CategoryId;


			await _productService.AddAsync(product, cancellationToken);

			return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> Update([FromRoute] int id, [FromForm] ProductRequest request, CancellationToken cancellationToken)
		{
			var product = await _productService.GetAsync(id, cancellationToken);

			if (product == null)
				return NotFound($"No movie was found with ID {id}");

			var isValidCategory = await _categoryService.IsvalidCategory(request.CategoryId);

			if (!isValidCategory)
				return BadRequest("Invalid genere ID!");

			if (request.Image != null)
			{
				if (!_allowedExtenstions.Contains(Path.GetExtension(request.Image.FileName).ToLower()))
					return BadRequest("Only .png and .jpg images are allowed!");

				if (request.Image.Length > _maxAllowedPosterSize)
					return BadRequest("Max allowed size for poster is 1MB!");
				using var dataStream = new MemoryStream();

				await request.Image.CopyToAsync(dataStream);

				product.Image = dataStream.ToArray();
			}
			product.Name = request.Name;
			product.Details = request.Details;
			product.IsAvailable = request.IsAvailable;
			product.Quantity = request.Quantity;
			product.Price = request.Price;
			product.CategoryId = request.CategoryId;

			var result=await _productService.UpdateASync(id,product, cancellationToken);
			if (!result)
				return NotFound();
			return NoContent();

		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken cancellationToken)
		{
			var result = await _productService.DeleteAsync(id, cancellationToken);
			if (!result) return NotFound();
			return NoContent();
		}
		[HttpPut("{id}/toggleAvailable")]
		public async Task<IActionResult> ToggleAvailable([FromRoute] int id, CancellationToken cancellationToken)
		{
			var result = await _productService.ToggleAvailableStatusAsync(id, cancellationToken);

			if (!result)
				return NotFound();

			return NoContent();
		}

	}

}
