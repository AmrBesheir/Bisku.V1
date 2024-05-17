using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bisku.Migrations
{
    /// <inheritdoc />
    public partial class addOfferTableswithAvialablity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvialable",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvialable",
                table: "Offers");
        }
    }
}
