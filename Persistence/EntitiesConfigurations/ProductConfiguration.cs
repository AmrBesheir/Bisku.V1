namespace Bisku.Persistence.EntitiesConfigurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasIndex(x=>x.Name).IsUnique();
			builder.Property(x => x.Name).HasMaxLength(100);
			builder.Property(x=>x.Details).HasMaxLength(1500);
		}
	}
}
