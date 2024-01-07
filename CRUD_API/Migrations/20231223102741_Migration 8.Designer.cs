﻿// <auto-generated />
using System;
using CRUD_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_API.Migrations
{
    [DbContext(typeof(DbContextCRUD))]
    [Migration("20231223102741_Migration 8")]
    partial class Migration8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD_API.Models.Account", b =>
                {
                    b.Property<int>("accountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("accountId"));

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("accountEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("accountName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("accountPassword")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("accountPhone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("accountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("CRUD_API.Models.AccountRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("accountId")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("accountId");

                    b.HasIndex("roleId");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("CRUD_API.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"));

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("categoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("CRUD_API.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customerId"));

                    b.Property<string>("customerEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("customerPassword")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("customerPhone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("customerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CRUD_API.Models.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderId"));

                    b.Property<int>("accountId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("district")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isRating")
                        .HasColumnType("bit");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("orderStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("orderTotal")
                        .HasColumnType("Money");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ward")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("orderId");

                    b.HasIndex("accountId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CRUD_API.Models.OrderDetail", b =>
                {
                    b.Property<int>("orderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderDetailId"));

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("orderDetailId");

                    b.HasIndex("orderId");

                    b.HasIndex("productId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("CRUD_API.Models.Rating", b =>
                {
                    b.Property<int>("ratingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ratingId"));

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ratingDate")
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("ratingStar")
                        .HasColumnType("int");

                    b.Property<string>("ratingText")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ratingId");

                    b.HasIndex("orderId");

                    b.HasIndex("productId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("CRUD_API.Models.Role", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roleId"));

                    b.Property<string>("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productId"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrlsJson")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("productDes")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("productPrice")
                        .HasColumnType("Money");

                    b.Property<string>("subImage")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("productId");

                    b.HasIndex("categoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CRUD_API.Models.AccountRoles", b =>
                {
                    b.HasOne("CRUD_API.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRUD_API.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CRUD_API.Models.Order", b =>
                {
                    b.HasOne("CRUD_API.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CRUD_API.Models.OrderDetail", b =>
                {
                    b.HasOne("CRUD_API.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product", "Product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CRUD_API.Models.Rating", b =>
                {
                    b.HasOne("CRUD_API.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product", "Product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("CRUD_API.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
