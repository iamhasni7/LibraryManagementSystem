﻿// <auto-generated />
using System;
using LibraryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    [DbContext(typeof(LibraryManagementSystemDbContext))]
    partial class LibraryManagementSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagementSystem.Models.Admin_Credentials", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("loginid")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("admin_credentials");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Book_Details", b =>
                {
                    b.Property<int>("book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("book_id"));

                    b.Property<string>("book_author")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("book_release_year")
                        .HasColumnType("int");

                    b.Property<string>("book_title")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("category_id")
                        .HasColumnType("int");

                    b.Property<int?>("shelf_id")
                        .HasColumnType("int");

                    b.HasKey("book_id");

                    b.HasIndex("category_id");

                    b.HasIndex("shelf_id");

                    b.ToTable("book");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Category_Details", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("category_id"));

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("category_id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Issued_Details", b =>
                {
                    b.Property<int>("issued_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("issued_id"));

                    b.Property<int?>("book_id")
                        .HasColumnType("int");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.HasKey("issued_id");

                    b.HasIndex("book_id");

                    b.HasIndex("user_id");

                    b.ToTable("issued_details");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Shelf_Details", b =>
                {
                    b.Property<int>("shelf_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("shelf_id"));

                    b.Property<string>("shelf_floor")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("shelf_number")
                        .HasColumnType("int");

                    b.HasKey("shelf_id");

                    b.ToTable("shelf");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.User_Details", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"));

                    b.Property<DateTime>("user_dob")
                        .HasColumnType("Date");

                    b.Property<string>("user_gender")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("user_type")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("user_id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Book_Details", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Category_Details", "Category_Details")
                        .WithMany("Book_Details")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("LibraryManagementSystem.Models.Shelf_Details", "Shelf_Details")
                        .WithMany("Book_Details")
                        .HasForeignKey("shelf_id")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category_Details");

                    b.Navigation("Shelf_Details");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Issued_Details", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Book_Details", "Book_Details")
                        .WithMany("Issued_Details")
                        .HasForeignKey("book_id")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("LibraryManagementSystem.Models.User_Details", "User_Details")
                        .WithMany("Issued_Details")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Book_Details");

                    b.Navigation("User_Details");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Book_Details", b =>
                {
                    b.Navigation("Issued_Details");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Category_Details", b =>
                {
                    b.Navigation("Book_Details");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Shelf_Details", b =>
                {
                    b.Navigation("Book_Details");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.User_Details", b =>
                {
                    b.Navigation("Issued_Details");
                });
#pragma warning restore 612, 618
        }
    }
}
