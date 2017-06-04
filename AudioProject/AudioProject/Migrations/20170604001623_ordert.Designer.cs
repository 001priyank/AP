using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AudioProject.Infrastructure;
using AudioProject.Entities.OrderManagement;

namespace AudioProject.Migrations
{
    [DbContext(typeof(AudioProjectContext))]
    [Migration("20170604001623_ordert")]
    partial class ordert
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AudioProject.Entities.Error", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("IsDirty");

                    b.Property<string>("Message");

                    b.Property<string>("StackTrace");

                    b.HasKey("Id");

                    b.ToTable("Error");
                });

            modelBuilder.Entity("AudioProject.Entities.OrderManagement.OrderFiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderFiles");
                });

            modelBuilder.Entity("AudioProject.Entities.OrderManagement.OrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompletionPercent");

                    b.Property<string>("Description");

                    b.Property<int>("OrderId");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("OrderTypeId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("AudioProject.Entities.OrderManagement.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderStatus");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AudioProject.Entities.Orders.OrderTypeCategorys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool?>("IsActive");

                    b.Property<bool?>("IsVisible");

                    b.Property<int?>("SortOrder");

                    b.HasKey("Id");

                    b.ToTable("OrderTypeCategorys");
                });

            modelBuilder.Entity("AudioProject.Entities.Orders.OrderTypeDescriptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool?>("IsActive");

                    b.Property<bool?>("IsVisible");

                    b.Property<int>("OrderTypeId");

                    b.Property<int?>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("OrderTypeId");

                    b.ToTable("OrderTypeDescriptions");
                });

            modelBuilder.Entity("AudioProject.Entities.Orders.OrderTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("IsActive");

                    b.Property<bool?>("IsVisible");

                    b.Property<int>("OrderTypeCategoryId");

                    b.Property<string>("OrderTypeDisplayName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("OrderTypeName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<float>("Price");

                    b.Property<float>("PriceFuture");

                    b.Property<int?>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("OrderTypeCategoryId");

                    b.ToTable("OrderTypes");
                });

            modelBuilder.Entity("AudioProject.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDirty");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("AudioProject.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsLocked");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AudioProject.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("AudioProject.Entities.OrderManagement.OrderFiles", b =>
                {
                    b.HasOne("AudioProject.Entities.OrderManagement.Orders", "Order")
                        .WithMany("OrderFiles")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AudioProject.Entities.OrderManagement.OrderItems", b =>
                {
                    b.HasOne("AudioProject.Entities.OrderManagement.Orders", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AudioProject.Entities.OrderManagement.Orders", b =>
                {
                    b.HasOne("AudioProject.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AudioProject.Entities.Orders.OrderTypeDescriptions", b =>
                {
                    b.HasOne("AudioProject.Entities.Orders.OrderTypes", "OrderType")
                        .WithMany("OrderTypeDescriptions")
                        .HasForeignKey("OrderTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AudioProject.Entities.Orders.OrderTypes", b =>
                {
                    b.HasOne("AudioProject.Entities.Orders.OrderTypeCategorys", "OrderTypeCategory")
                        .WithMany("OrderTypes")
                        .HasForeignKey("OrderTypeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AudioProject.Entities.UserRole", b =>
                {
                    b.HasOne("AudioProject.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AudioProject.Entities.User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
