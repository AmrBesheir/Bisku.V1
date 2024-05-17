
namespace Bisku.Persistence.EntitiesConfigurations
{
	public class OfferConfiguration : IEntityTypeConfiguration<Offer>
	{
		public void Configure(EntityTypeBuilder<Offer> builder)
		{
			builder.Property(x => x.Details).HasMaxLength(250);
			
		}
	}
}
