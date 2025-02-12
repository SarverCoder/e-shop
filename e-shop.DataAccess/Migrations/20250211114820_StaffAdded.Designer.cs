﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using e_shop.DataAccess;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20250211114820_StaffAdded")]
    partial class StaffAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("e_shop.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category_description");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("icon");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_path");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer")
                        .HasColumnName("parent_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_category");

                    b.HasIndex("ParentId")
                        .HasDatabaseName("ix_category_parent_id");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamptz")
                        .HasColumnName("created_at");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("discount_price");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("product_description");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("product_name");

                    b.Property<string>("ProductNote")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("product_note");

                    b.Property<decimal>("ProductWeight")
                        .HasColumnType("numeric")
                        .HasColumnName("product_weight");

                    b.Property<bool>("Published")
                        .HasColumnType("boolean")
                        .HasColumnName("published");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<decimal>("RegularPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("regular_price");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("sku");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(165)
                        .HasColumnType("character varying(165)")
                        .HasColumnName("short_description");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamptz")
                        .HasColumnName("updated_at");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id")
                        .HasColumnOrder(1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id")
                        .HasColumnOrder(2);

                    b.HasKey("ProductId", "CategoryId")
                        .HasName("pk_product_categories");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_product_categories_category_id");

                    b.ToTable("product_categories", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.ProductTag", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int>("TagId")
                        .HasColumnType("integer")
                        .HasColumnName("tag_id");

                    b.HasKey("ProductId", "TagId")
                        .HasName("pk_product_tags");

                    b.HasIndex("TagId")
                        .HasDatabaseName("ix_product_tags_tag_id");

                    b.ToTable("product_tags", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.PrimitiveCollection<string[]>("Privilege")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("privilege");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("role_name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_role");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.StaffAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<string>("ProfileImg")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("profile_img");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("registered_at");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("integer")
                        .HasColumnName("update_by");

                    b.HasKey("Id")
                        .HasName("pk_staff_accounts");

                    b.ToTable("staff_accounts", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.StaffRole", b =>
                {
                    b.Property<int>("StaffID")
                        .HasColumnType("integer")
                        .HasColumnName("staff_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.HasKey("StaffID", "RoleId")
                        .HasName("pk_staff_role");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_staff_role_role_id");

                    b.ToTable("staff_role", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("icon");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("tag_name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_tags");

                    b.ToTable("tags", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Category", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_category_category_parent_id");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_categories_category_category_id");

                    b.HasOne("e_shop.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_categories_products_product_id");

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.ProductTag", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_tags_products_product_id");

                    b.HasOne("e_shop.Domain.Entities.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_tags_tags_tag_id");

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.StaffRole", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Role", "Role")
                        .WithMany("StaffRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_staff_role_role_role_id");

                    b.HasOne("e_shop.Domain.Entities.StaffAccount", "StaffAccount")
                        .WithMany("StaffRoles")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_staff_role_staff_accounts_staff_id");

                    b.Navigation("Role");

                    b.Navigation("StaffAccount");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductCategories");

                    b.Navigation("ProductTags");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Role", b =>
                {
                    b.Navigation("StaffRoles");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.StaffAccount", b =>
                {
                    b.Navigation("StaffRoles");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Tag", b =>
                {
                    b.Navigation("ProductTags");
                });
#pragma warning restore 612, 618
        }
    }
}
