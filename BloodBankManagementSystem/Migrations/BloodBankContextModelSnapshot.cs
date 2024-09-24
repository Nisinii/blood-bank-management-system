﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodBankManagementSystem.Migrations
{
    [DbContext(typeof(BloodBankContext))]
    partial class BloodBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BloodDonation", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DonationId"));

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfDonation")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StorageLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DonationId");

                    b.ToTable("BloodDonations");
                });

            modelBuilder.Entity("BloodRequirement", b =>
                {
                    b.Property<int>("RequirementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("RequirementId"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RequiredBloodGroup")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("RequirementId");

                    b.ToTable("BloodRequirements");
                });

            modelBuilder.Entity("Donor", b =>
                {
                    b.Property<int>("DonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DonorId"));

                    b.Property<string>("BloodGroup")
                        .HasColumnType("longtext");

                    b.Property<string>("Contact")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastDonationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DonorId");

                    b.ToTable("Donors");
                });
#pragma warning restore 612, 618
        }
    }
}
