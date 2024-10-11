using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    /// <inheritdoc />
    public partial class cat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyIntroduction",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "CompanyIntroductionEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ContactUs",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ContactUsEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImageSlider",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImportGoods",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ImportGoodsEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KasraComputer",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KasraComputerEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KasraTaminAndishan",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KasraTaminAndishanEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KhizrTrading",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "KhizrTradingEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ParsMayOnlineStore",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ParsMayOnlineStoreEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "PricingDistribution",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "PricingDistributionEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ProductWarranty",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ProductWarrantyEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SaleDistribution",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SaleDistributionEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoCompanyIntroductionCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoCompanyIntroductionDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoCompanyIntroductionTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoContactUsCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoContactUsDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoContactUsTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoImportGoodsCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoImportGoodsDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoImportGoodsTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKasraComputerCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKasraComputerDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKasraComputerTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKasraTaminAndishanCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKasraTaminAndishanDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKasraTaminAndishanTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKhizrTradingCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKhizrTradingDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoKhizrTradingTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoParsMayOnlineStoreCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoParsMayOnlineStoreDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoParsMayOnlineStoreTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoPricingDistributionCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoPricingDistributionDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoPricingDistributionTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoProductWarrantyCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoProductWarrantyDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoProductWarrantyTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoSaleDistributionCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoSaleDistributionDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoSaleDistributionTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoWarrantyServiceCanonical",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoWarrantyServiceDesc",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SeoWarrantyServiceTitle",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSlider",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "SubTitleSliderEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSlider",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "TitleSliderEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "WarrantyService",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "WarrantyServiceEn",
                table: "Pages");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPages_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubPages_CategoryId",
                table: "SubPages",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubPages");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "CompanyIntroduction",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIntroductionEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactUs",
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
                name: "ImportGoods",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportGoodsEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KasraComputer",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KasraComputerEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KasraTaminAndishan",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KasraTaminAndishanEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KhizrTrading",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KhizrTradingEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParsMayOnlineStore",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParsMayOnlineStoreEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PricingDistribution",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PricingDistributionEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductWarranty",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductWarrantyEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleDistribution",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleDistributionEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoCompanyIntroductionCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoCompanyIntroductionDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoCompanyIntroductionTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoContactUsCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoContactUsDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoContactUsTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoImportGoodsCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoImportGoodsDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoImportGoodsTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKasraComputerCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKasraComputerDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKasraComputerTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKasraTaminAndishanCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKasraTaminAndishanDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKasraTaminAndishanTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKhizrTradingCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKhizrTradingDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoKhizrTradingTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoParsMayOnlineStoreCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoParsMayOnlineStoreDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoParsMayOnlineStoreTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoPricingDistributionCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoPricingDistributionDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoPricingDistributionTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoProductWarrantyCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoProductWarrantyDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoProductWarrantyTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoSaleDistributionCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoSaleDistributionDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoSaleDistributionTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoWarrantyServiceCanonical",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoWarrantyServiceDesc",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeoWarrantyServiceTitle",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSlider",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitleSliderEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSlider",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSliderEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarrantyService",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarrantyServiceEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
