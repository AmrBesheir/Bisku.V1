using Bisku.Contracts.Offers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bisku.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OffersController(IOfferService offerService) : ControllerBase
	{
		private readonly IOfferService _offerService=offerService;

		[HttpGet("")]
		public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
		{
			var offers= await _offerService.GetAllOffersAsync(cancellationToken);
			var response= offers.Adapt<IEnumerable<OfferResponse>>();
			return Ok(response);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdAsync([FromRoute]int id,CancellationToken cancellationToken)
		{
			var offer= await _offerService.GetOfferAsync(id, cancellationToken);
			var response = offer.Adapt<OfferResponse>();

			return offer is null ? NotFound() : Ok(response);
		}
		[HttpPost("")]
		public async Task<IActionResult> AddOfferAsync([FromBody]OfferRequest request,CancellationToken cancellationToken)
		{
			var newOffer = await _offerService.AddAsync(request.Adapt<Offer>(), cancellationToken);

			return CreatedAtAction(nameof(GetByIdAsync), new { id = newOffer.Id }, newOffer);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> Update([FromRoute] int id, [FromBody] OfferRequest request, CancellationToken cancellationToken)
		{
			var result = await _offerService.UpdateAsync(id, request.Adapt<Offer>(), cancellationToken);

			if (!result)
				return NotFound();

			return NoContent();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken cancellationToken)
		{
			var isDeleted = await _offerService.DeleteAsync(id, cancellationToken);
			if (!isDeleted)
				return NotFound();

			return NoContent();
		}
		[HttpPut("{id}/toggleAvailable")]
		public async Task<IActionResult> ToggleAvialable([FromRoute] int id, CancellationToken cancellationToken)
		{
			var result = await _offerService.ToggleAvailableStatusAsync(id, cancellationToken);

			if (!result)
				return NotFound();

			return NoContent();
		}

	}
}
