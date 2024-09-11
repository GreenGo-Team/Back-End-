﻿// <auto-generated />
using System;
using GreenGo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenGo.Migrations
{
    [DbContext(typeof(GreenGoDbContext))]
    [Migration("20240911145610_Intial Create")]
    partial class IntialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenGo.Models.Center", b =>
                {
                    b.Property<int>("Center_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Center_ID"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Center_ID");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("GreenGo.Models.Container", b =>
                {
                    b.Property<int>("Container_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Container_ID"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Container_ID");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("GreenGo.Models.Content", b =>
                {
                    b.Property<int>("Content_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Content_ID"));

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Content_ID");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("GreenGo.Models.Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Customer_ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RewardPoints")
                        .HasColumnType("int");

                    b.HasKey("Customer_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GreenGo.Models.CustomerContent", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ContentId");

                    b.HasIndex("ContentId");

                    b.ToTable("CustomerContents");
                });

            modelBuilder.Entity("GreenGo.Models.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("RecyclabilityStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ScanDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("GreenGo.Models.Process", b =>
                {
                    b.Property<int>("Process_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Process_ID"));

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<int>("ContainerId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Recycling_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Process_ID");

                    b.HasIndex("CenterId");

                    b.HasIndex("ContainerId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ItemsId");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("GreenGo.Models.Reward", b =>
                {
                    b.Property<int>("Reward_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Reward_ID"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("PointsRequied")
                        .HasColumnType("int");

                    b.HasKey("Reward_ID");

                    b.HasIndex("CustomerId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("GreenGo.Models.CustomerContent", b =>
                {
                    b.HasOne("GreenGo.Models.Content", "Content")
                        .WithMany("CustomerContents")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenGo.Models.Customer", "Customer")
                        .WithMany("CustomerContents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GreenGo.Models.Items", b =>
                {
                    b.HasOne("GreenGo.Models.Customer", "Customer")
                        .WithMany("Items")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GreenGo.Models.Process", b =>
                {
                    b.HasOne("GreenGo.Models.Center", "Center")
                        .WithMany("Processes")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GreenGo.Models.Container", "Container")
                        .WithMany("Processes")
                        .HasForeignKey("ContainerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GreenGo.Models.Customer", "Customer")
                        .WithMany("Processes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GreenGo.Models.Items", "Items")
                        .WithMany("Processes")
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Center");

                    b.Navigation("Container");

                    b.Navigation("Customer");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("GreenGo.Models.Reward", b =>
                {
                    b.HasOne("GreenGo.Models.Customer", "Customer")
                        .WithMany("Rewards")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GreenGo.Models.Center", b =>
                {
                    b.Navigation("Processes");
                });

            modelBuilder.Entity("GreenGo.Models.Container", b =>
                {
                    b.Navigation("Processes");
                });

            modelBuilder.Entity("GreenGo.Models.Content", b =>
                {
                    b.Navigation("CustomerContents");
                });

            modelBuilder.Entity("GreenGo.Models.Customer", b =>
                {
                    b.Navigation("CustomerContents");

                    b.Navigation("Items");

                    b.Navigation("Processes");

                    b.Navigation("Rewards");
                });

            modelBuilder.Entity("GreenGo.Models.Items", b =>
                {
                    b.Navigation("Processes");
                });
#pragma warning restore 612, 618
        }
    }
}
