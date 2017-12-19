﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PropertyManagementService.Data;
using PropertyManagementService.Domain.Infrastructure.Enum;
using System;

namespace PropertyManagementService.Data.Migrations
{
    [DbContext(typeof(PropertyManagementServiceDbContext))]
    [Migration("20171216171045_ApartmentNumberIsUnique")]
    partial class ApartmentNumberIsUnique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Area");

                    b.Property<int>("BuildingId");

                    b.Property<int>("Dogs");

                    b.Property<string>("Number")
                        .IsRequired();

                    b.Property<string>("OwnerId");

                    b.Property<int>("Residents");

                    b.HasKey("Id");

                    b.HasAlternateKey("Number");

                    b.HasIndex("BuildingId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApartmentId");

                    b.Property<DateTime>("DueDate");

                    b.Property<bool>("IsPaid");

                    b.Property<int>("Period");

                    b.Property<decimal>("TotalAmount");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.BillUtility", b =>
                {
                    b.Property<int>("BillId");

                    b.Property<int>("UtilityBuildingId");

                    b.Property<int?>("UtilityBuildingBuildingId");

                    b.Property<int?>("UtilityBuildingUtilityId");

                    b.HasKey("BillId", "UtilityBuildingId");

                    b.HasIndex("UtilityBuildingUtilityId", "UtilityBuildingBuildingId");

                    b.ToTable("BillUtility");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Contract")
                        .IsRequired();

                    b.Property<string>("ManagerId");

                    b.Property<DateTime?>("ServiceEndDate");

                    b.Property<DateTime>("ServiceStartDate");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.UnsubscribedUtility", b =>
                {
                    b.Property<int>("ApartmentId");

                    b.Property<int>("UtilityId");

                    b.HasKey("ApartmentId", "UtilityId");

                    b.HasIndex("UtilityId");

                    b.ToTable("UnsubscribedUtility");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.UserRoleName", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleName");

                    b.HasKey("UserId", "RoleName");

                    b.ToTable("UserRoleNames");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Utility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Utilities");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.UtilityBuilding", b =>
                {
                    b.Property<int>("UtilityId");

                    b.Property<int>("BuildingId");

                    b.Property<bool>("IsPerResident");

                    b.Property<bool>("IsSubscribable");

                    b.Property<decimal>("Price");

                    b.Property<int>("Routine");

                    b.HasKey("UtilityId", "BuildingId");

                    b.HasIndex("BuildingId");

                    b.ToTable("BuildingUtilities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PropertyManagementService.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Apartment", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.Building", "Building")
                        .WithMany("Apartments")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PropertyManagementService.Domain.User", "Owner")
                        .WithMany("ApartmentsAsOwner")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Bill", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.Apartment", "Apartment")
                        .WithMany("Bills")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PropertyManagementService.Domain.BillUtility", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.Bill", "Bill")
                        .WithMany("Utilities")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PropertyManagementService.Domain.UtilityBuilding", "UtilityBuilding")
                        .WithMany()
                        .HasForeignKey("UtilityBuildingUtilityId", "UtilityBuildingBuildingId");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.Building", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.User", "Manager")
                        .WithMany("BuildingsAsManager")
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("PropertyManagementService.Domain.UnsubscribedUtility", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.Apartment", "Apartment")
                        .WithMany("UnsubscribedUtilities")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PropertyManagementService.Domain.Utility", "Utility")
                        .WithMany()
                        .HasForeignKey("UtilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PropertyManagementService.Domain.UserRoleName", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.User", "User")
                        .WithMany("RolesNames")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PropertyManagementService.Domain.UtilityBuilding", b =>
                {
                    b.HasOne("PropertyManagementService.Domain.Building", "Building")
                        .WithMany("Utilities")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PropertyManagementService.Domain.Utility", "Utility")
                        .WithMany("Buildings")
                        .HasForeignKey("UtilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}