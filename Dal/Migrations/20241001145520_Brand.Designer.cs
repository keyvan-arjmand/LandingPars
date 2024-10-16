﻿// <auto-generated />
using System;
using Dal.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using AppContext = Dal.DataBase.AppContext;

#nullable disable

namespace Dal.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20241001145520_Brand")]
    partial class Brand
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dal.Entity.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Dal.Entity.LandingPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyIntroduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyIntroductionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactUs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactUsEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSlider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSlider2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSlider3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSlider4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSlider5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTopBanner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTopBannerHref")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportGoods")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportGoodsEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("KasraComputer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KasraComputerEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KasraTaminAndishan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KasraTaminAndishanEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhizrTrading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhizrTradingEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParsMayOnlineStore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParsMayOnlineStoreEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PricingDistribution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PricingDistributionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductWarranty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductWarrantyEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleDistribution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleDistributionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoCompanyIntroductionCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoCompanyIntroductionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoCompanyIntroductionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoContactUsCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoContactUsDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoContactUsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoImportGoodsCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoImportGoodsDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoImportGoodsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoIndexCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoIndexDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoIndexTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKasraComputerCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKasraComputerDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKasraComputerTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKasraTaminAndishanCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKasraTaminAndishanDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKasraTaminAndishanTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKhizrTradingCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKhizrTradingDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoKhizrTradingTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoParsMayOnlineStoreCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoParsMayOnlineStoreDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoParsMayOnlineStoreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoPricingDistributionCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoPricingDistributionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoPricingDistributionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoProductWarrantyCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoProductWarrantyDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoProductWarrantyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoSaleDistributionCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoSaleDistributionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoSaleDistributionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoWarrantyServiceCanonical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoWarrantyServiceDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoWarrantyServiceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSlider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSlider2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSlider3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSlider4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSlider5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSliderEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSliderEn2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSliderEn3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSliderEn4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitleSliderEn5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSlider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSlider2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSlider3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSlider4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSlider5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSliderEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSliderEn2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSliderEn3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSliderEn4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSliderEn5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarrantyService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarrantyServiceEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Dal.Entity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Dal.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ConfirmCodeExpireTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Dal.Entity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Dal.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Dal.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Dal.Entity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dal.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Dal.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
