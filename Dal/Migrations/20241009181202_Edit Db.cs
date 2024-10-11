using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    /// <inheritdoc />
    public partial class EditDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "TitleSliderEn5",
                table: "Pages",
                newName: "ServiceTitle3");

            migrationBuilder.RenameColumn(
                name: "TitleSliderEn4",
                table: "Pages",
                newName: "ServiceTitle2");

            migrationBuilder.RenameColumn(
                name: "TitleSliderEn3",
                table: "Pages",
                newName: "ServiceTitle1");

            migrationBuilder.RenameColumn(
                name: "TitleSliderEn2",
                table: "Pages",
                newName: "ServiceLogo3");

            migrationBuilder.RenameColumn(
                name: "TitleSliderEn",
                table: "Pages",
                newName: "ServiceLogo2");

            migrationBuilder.RenameColumn(
                name: "TitleSlider5",
                table: "Pages",
                newName: "ServiceLogo1");

            migrationBuilder.RenameColumn(
                name: "TitleSlider4",
                table: "Pages",
                newName: "ServiceImage3");

            migrationBuilder.RenameColumn(
                name: "TitleSlider3",
                table: "Pages",
                newName: "ServiceImage2");

            migrationBuilder.RenameColumn(
                name: "TitleSlider2",
                table: "Pages",
                newName: "ServiceImage1");

            migrationBuilder.RenameColumn(
                name: "TitleSlider",
                table: "Pages",
                newName: "ServiceHref3");

            migrationBuilder.RenameColumn(
                name: "SubTitleSliderEn5",
                table: "Pages",
                newName: "ServiceHref2");

            migrationBuilder.RenameColumn(
                name: "SubTitleSliderEn4",
                table: "Pages",
                newName: "ServiceHref1");

            migrationBuilder.RenameColumn(
                name: "SubTitleSliderEn3",
                table: "Pages",
                newName: "ServiceDesc3");

            migrationBuilder.RenameColumn(
                name: "SubTitleSliderEn2",
                table: "Pages",
                newName: "ServiceDesc2");

            migrationBuilder.RenameColumn(
                name: "SubTitleSliderEn",
                table: "Pages",
                newName: "ServiceDesc1");

            migrationBuilder.RenameColumn(
                name: "SubTitleSlider5",
                table: "Pages",
                newName: "Sec2Title");

            migrationBuilder.RenameColumn(
                name: "SubTitleSlider4",
                table: "Pages",
                newName: "Sec1Title");

            migrationBuilder.RenameColumn(
                name: "SubTitleSlider3",
                table: "Pages",
                newName: "Sec1SubTitle");

            migrationBuilder.RenameColumn(
                name: "SubTitleSlider2",
                table: "Pages",
                newName: "Sec1Image");

            migrationBuilder.RenameColumn(
                name: "SubTitleSlider",
                table: "Pages",
                newName: "Sec1Desc");

            migrationBuilder.RenameColumn(
                name: "ImageTopBannerHref",
                table: "Pages",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "ImageTopBanner",
                table: "Pages",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "ImageSlider5",
                table: "Pages",
                newName: "DescCart");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceTitle3",
                table: "Pages",
                newName: "TitleSliderEn5");

            migrationBuilder.RenameColumn(
                name: "ServiceTitle2",
                table: "Pages",
                newName: "TitleSliderEn4");

            migrationBuilder.RenameColumn(
                name: "ServiceTitle1",
                table: "Pages",
                newName: "TitleSliderEn3");

            migrationBuilder.RenameColumn(
                name: "ServiceLogo3",
                table: "Pages",
                newName: "TitleSliderEn2");

            migrationBuilder.RenameColumn(
                name: "ServiceLogo2",
                table: "Pages",
                newName: "TitleSliderEn");

            migrationBuilder.RenameColumn(
                name: "ServiceLogo1",
                table: "Pages",
                newName: "TitleSlider5");

            migrationBuilder.RenameColumn(
                name: "ServiceImage3",
                table: "Pages",
                newName: "TitleSlider4");

            migrationBuilder.RenameColumn(
                name: "ServiceImage2",
                table: "Pages",
                newName: "TitleSlider3");

            migrationBuilder.RenameColumn(
                name: "ServiceImage1",
                table: "Pages",
                newName: "TitleSlider2");

            migrationBuilder.RenameColumn(
                name: "ServiceHref3",
                table: "Pages",
                newName: "TitleSlider");

            migrationBuilder.RenameColumn(
                name: "ServiceHref2",
                table: "Pages",
                newName: "SubTitleSliderEn5");

            migrationBuilder.RenameColumn(
                name: "ServiceHref1",
                table: "Pages",
                newName: "SubTitleSliderEn4");

            migrationBuilder.RenameColumn(
                name: "ServiceDesc3",
                table: "Pages",
                newName: "SubTitleSliderEn3");

            migrationBuilder.RenameColumn(
                name: "ServiceDesc2",
                table: "Pages",
                newName: "SubTitleSliderEn2");

            migrationBuilder.RenameColumn(
                name: "ServiceDesc1",
                table: "Pages",
                newName: "SubTitleSliderEn");

            migrationBuilder.RenameColumn(
                name: "Sec2Title",
                table: "Pages",
                newName: "SubTitleSlider5");

            migrationBuilder.RenameColumn(
                name: "Sec1Title",
                table: "Pages",
                newName: "SubTitleSlider4");

            migrationBuilder.RenameColumn(
                name: "Sec1SubTitle",
                table: "Pages",
                newName: "SubTitleSlider3");

            migrationBuilder.RenameColumn(
                name: "Sec1Image",
                table: "Pages",
                newName: "SubTitleSlider2");

            migrationBuilder.RenameColumn(
                name: "Sec1Desc",
                table: "Pages",
                newName: "SubTitleSlider");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Pages",
                newName: "ImageTopBannerHref");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Pages",
                newName: "ImageTopBanner");

            migrationBuilder.RenameColumn(
                name: "DescCart",
                table: "Pages",
                newName: "ImageSlider5");

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
        }
    }
}
