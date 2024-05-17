namespace Bisku.Persistence.EntitiesConfigurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasIndex(x=>x.Name).IsUnique();

			builder.Property(x => x.Name).HasMaxLength(100);
			builder.Property(x => x.Details).HasMaxLength(1500);

		}
	}
}
