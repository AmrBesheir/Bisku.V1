namespace Bisku.Entities
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }=string.Empty;
		public string Details { get; set; }=string.Empty;
		public bool IsAvailable {  get; set; }

		// Navigation property to represent the products in this category
		public virtual ICollection<Product> Products { get; set; }
	}
}
