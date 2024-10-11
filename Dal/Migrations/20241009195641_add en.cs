using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    /// <inheritdoc />
    public partial class adden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescCartEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sec1DescEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sec1SubTitleEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sec1TitleEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sec2TitleEn",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceDesc1En",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceDesc2En",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceDesc3En",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceTitle1En",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceTitle2En",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceTitle3En",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescCartEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Sec1DescEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Sec1SubTitleEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Sec1TitleEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Sec2TitleEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ServiceDesc1En",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ServiceDesc2En",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ServiceDesc3En",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ServiceTitle1En",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ServiceTitle2En",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ServiceTitle3En",
                table: "Pages");
        }
    }
}
