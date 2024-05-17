namespace Bisku.Persistence
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Offer> Offers { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<ProductOffer>() // primary key
			//     .HasKey(x => new { x.ProductId, x.OfferId });
			modelBuilder.Entity<ProductOffer>()
				  .HasKey(po => new { po.ProductId, po.OfferId });

			modelBuilder.Entity<ProductOffer>()
				.HasOne(po => po.Product)
				.WithMany(p => p.ProductOffers)
				.HasForeignKey(po => po.ProductId);

			modelBuilder.Entity<ProductOffer>()
				.HasOne(po => po.Offer)
				.WithMany(o => o.ProductOffers)
				.HasForeignKey(po => po.OfferId);

			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Entities Configurations
			base.OnModelCreating(modelBuilder);
		}
	}
}
