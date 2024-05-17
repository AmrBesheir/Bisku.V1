namespace Bisku.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Details { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public byte[]Image { get; set; }
		public bool IsAvailable {  get; set; }
		
		// Foreign key to represent the category of the product
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }

		public virtual ICollection<ProductOffer> ProductOffers { get; set; }
	}
}
