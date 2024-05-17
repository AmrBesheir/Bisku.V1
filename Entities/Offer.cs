using System.ComponentModel.DataAnnotations;

namespace Bisku.Entities
{
	public class Offer
	{
		public int Id { get; set; }
		public string Details { get; set; }=string.Empty;
		[DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)] // Displays percentage with 2 decimal places
		[Range(0, 1, ErrorMessage = "Discount percentage must be between 0 and 100%.")]
		public decimal DiscountPercentage { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public bool IsAvialable {  get; set; }

		// Navigation property to represent the products associated with this offer
		public virtual ICollection<ProductOffer> ProductOffers { get; set; }
	}
}
