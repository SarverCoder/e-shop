﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using e_shop.DataAccess;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
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
                        .HasColumnType("text")
                        .HasColumnName("category_description");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Icon")
                        .HasColumnType("text")
                        .HasColumnName("icon");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text")
                        .HasColumnName("image_path");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer")
                        .HasColumnName("parent_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.HasIndex("ParentId")
                        .HasDatabaseName("ix_categories_parent_id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderApprovedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_approved_at");

                    b.Property<DateTime>("OrderDeliveredCarrierDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_delivered_carrier_date");

                    b.Property<DateTime>("OrderDeliveredCustomerDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_delivered_customer_date");

                    b.HasKey("Id")
                        .HasName("pk_orders");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("pk_order_items");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_order_items_product_id");

                    b.ToTable("order_items", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Product", b =>
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

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("discount_price");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("text")
                        .HasColumnName("product_description");

                    b.Property<string>("ProductName")
                        .HasColumnType("text")
                        .HasColumnName("product_name");

                    b.Property<string>("ProductNote")
                        .HasColumnType("text")
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
                        .HasColumnType("text")
                        .HasColumnName("sku");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text")
                        .HasColumnName("short_description");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
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

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

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

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

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
                        .HasName("pk_staff_roles");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_staff_roles_role_id");

                    b.ToTable("staff_roles", (string)null);
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

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
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
                        .HasConstraintName("fk_categories_categories_parent_id");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_items_orders_order_id");

                    b.HasOne("e_shop.Domain.Entities.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_items_products_product_id");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_categories_categories_category_id");

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
                        .HasConstraintName("fk_staff_roles_roles_role_id");

                    b.HasOne("e_shop.Domain.Entities.StaffAccount", "StaffAccount")
                        .WithMany("StaffRoles")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_staff_roles_staff_accounts_staff_id");

                    b.Navigation("Role");

                    b.Navigation("StaffAccount");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderItems");

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
