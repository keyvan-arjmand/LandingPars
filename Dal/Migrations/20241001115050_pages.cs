using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    /// <inheritdoc />
    public partial class pages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeoIndexTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoIndexDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoIndexCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIntroduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCompanyIntroductionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCompanyIntroductionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCompanyIntroductionCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParsMayOnlineStore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoParsMayOnlineStoreTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoParsMayOnlineStoreDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoParsMayOnlineStoreCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KasraComputer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKasraComputerTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKasraComputerDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKasraComputerCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KasraTaminAndishan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKasraTaminAndishanTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKasraTaminAndishanDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKasraTaminAndishanCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhizrTrading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKhizrTradingTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKhizrTradingDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKhizrTradingCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarrantyService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoWarrantyServiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoWarrantyServiceDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoWarrantyServiceCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportGoods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoImportGoodsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoImportGoodsDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoImportGoodsCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricingDistribution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoPricingDistributionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoPricingDistributionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoPricingDistributionCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductWarranty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoProductWarrantyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoProductWarrantyDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoProductWarrantyCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleDistribution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSaleDistributionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSaleDistributionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoSaleDistributionCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoContactUsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoContactUsDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoContactUsCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");
        }
    }
}
