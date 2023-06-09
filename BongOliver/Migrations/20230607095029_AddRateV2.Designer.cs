﻿// <auto-generated />
using System;
using BongOliver.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BongOliver.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230607095029_AddRateV2")]
    partial class AddRateV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BongOliver.Models.Booking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stylistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("stylistId");

                    b.HasIndex("userId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BongOliver.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("dateModify")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("BongOliver.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BongOliver.Models.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("bookingId")
                        .HasColumnType("int");

                    b.Property<string>("mode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("bookingId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BongOliver.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("productTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("productTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BongOliver.Models.ProductType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("BongOliver.Models.Rate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<int>("serviceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("serviceId");

                    b.HasIndex("userId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("BongOliver.Models.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BongOliver.Models.Service", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("serviceTypeId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("serviceTypeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("BongOliver.Models.ServiceType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("BongOliver.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gender")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("isVerify")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("rank")
                        .HasColumnType("float");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("waletId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.HasIndex("waletId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BongOliver.Models.Walet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<double>("money")
                        .HasColumnType("float");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Walets");
                });

            modelBuilder.Entity("BookingService", b =>
                {
                    b.Property<int>("Bookingsid")
                        .HasColumnType("int");

                    b.Property<int>("Servicesid")
                        .HasColumnType("int");

                    b.HasKey("Bookingsid", "Servicesid");

                    b.HasIndex("Servicesid");

                    b.ToTable("BookingService");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("Ordersid")
                        .HasColumnType("int");

                    b.Property<int>("Productsid")
                        .HasColumnType("int");

                    b.HasKey("Ordersid", "Productsid");

                    b.HasIndex("Productsid");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("BongOliver.Models.Booking", b =>
                {
                    b.HasOne("BongOliver.Models.User", "Stylist")
                        .WithMany()
                        .HasForeignKey("stylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BongOliver.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stylist");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BongOliver.Models.Order", b =>
                {
                    b.HasOne("BongOliver.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BongOliver.Models.Payment", b =>
                {
                    b.HasOne("BongOliver.Models.Booking", "Booking")
                        .WithOne("Payment")
                        .HasForeignKey("BongOliver.Models.Payment", "bookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("BongOliver.Models.Product", b =>
                {
                    b.HasOne("BongOliver.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("productTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BongOliver.Models.Rate", b =>
                {
                    b.HasOne("BongOliver.Models.Service", "Service")
                        .WithMany("Rates")
                        .HasForeignKey("serviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BongOliver.Models.User", "User")
                        .WithMany("Rates")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BongOliver.Models.Service", b =>
                {
                    b.HasOne("BongOliver.Models.ServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("serviceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("BongOliver.Models.User", b =>
                {
                    b.HasOne("BongOliver.Models.Role", "role")
                        .WithMany("users")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BongOliver.Models.Walet", "Walet")
                        .WithOne("User")
                        .HasForeignKey("BongOliver.Models.User", "waletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Walet");

                    b.Navigation("role");
                });

            modelBuilder.Entity("BookingService", b =>
                {
                    b.HasOne("BongOliver.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("Bookingsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BongOliver.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("Servicesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("BongOliver.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("Ordersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BongOliver.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("Productsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BongOliver.Models.Booking", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("BongOliver.Models.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BongOliver.Models.Role", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("BongOliver.Models.Service", b =>
                {
                    b.Navigation("Rates");
                });

            modelBuilder.Entity("BongOliver.Models.ServiceType", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("BongOliver.Models.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Orders");

                    b.Navigation("Rates");
                });

            modelBuilder.Entity("BongOliver.Models.Walet", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
