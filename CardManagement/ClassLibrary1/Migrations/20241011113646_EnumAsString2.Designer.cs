﻿// <auto-generated />
using System;
using CardManagementModels.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardManagementModels.Migrations
{
    [DbContext(typeof(CardManagementContext))]
    [Migration("20241011113646_EnumAsString2")]
    partial class EnumAsString2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardManagement.Models.Account", b =>
                {
                    b.Property<string>("AccId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("CustomerCustId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("accountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccId");

                    b.HasIndex("CustomerCustId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("CardManagement.Models.Customer", b =>
                {
                    b.Property<string>("CustId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CardManagement.Models.Transactions", b =>
                {
                    b.Property<string>("TxnId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountAccId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("transactionType")
                        .HasColumnType("int");

                    b.HasKey("TxnId");

                    b.HasIndex("AccountAccId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CardManagement.Models.Account", b =>
                {
                    b.HasOne("CardManagement.Models.Customer", null)
                        .WithMany("Accounts")
                        .HasForeignKey("CustomerCustId");
                });

            modelBuilder.Entity("CardManagement.Models.Transactions", b =>
                {
                    b.HasOne("CardManagement.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountAccId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CardManagement.Models.Customer", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
