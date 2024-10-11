using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    /// <inheritdoc />
    public partial class Brand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyIntroductionEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactUsEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSlider",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSlider2",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSlider3",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSlider4",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSlider5",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageTopBanner",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageTopBannerHref",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportGoodsEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KasraComputerEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KasraTaminAndishanEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KhizrTradingEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParsMayOnlineStoreEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PricingDistributionEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductWarrantyEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleDistributionEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSlider",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSlider2",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSlider3",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSlider4",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSlider5",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSliderEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSliderEn2",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSliderEn3",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSliderEn4",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSliderEn5",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSlider",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSlider2",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSlider3",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSlider4",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSlider5",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSliderEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSliderEn2",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSliderEn3",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSliderEn4",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSliderEn5",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarrantyServiceEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropColumn(
                name: "CompanyIntroductionEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ContactUsEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageSlider",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageSlider2",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageSlider3",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageSlider4",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageSlider5",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageTopBanner",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageTopBannerHref",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImportGoodsEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KasraComputerEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KasraTaminAndishanEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KhizrTradingEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ParsMayOnlineStoreEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "PricingDistributionEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ProductWarrantyEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SaleDistributionEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSlider",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSlider2",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSlider3",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSlider4",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSlider5",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSliderEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSliderEn2",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSliderEn3",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSliderEn4",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSliderEn5",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSlider",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSlider2",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSlider3",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSlider4",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSlider5",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSliderEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSliderEn2",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSliderEn3",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSliderEn4",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSliderEn5",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "WarrantyServiceEn",
                table: "Pages");
        }
    }
}
