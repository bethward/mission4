﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission4.Models;

namespace mission4.Migrations
{
    [DbContext(typeof(FilmsDBContext))]
    partial class FilmsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mission4.Models.AddFilmModel", b =>
                {
                    b.Property<int>("AppId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppId");

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            AppId = 1,
                            CategoryId = 4,
                            Director = "Some Guy",
                            Edited = false,
                            Lent = "",
                            Notes = "Such a great movie",
                            Rating = "PG",
                            Title = "Cinderella",
                            Year = (ushort)1996
                        },
                        new
                        {
                            AppId = 2,
                            CategoryId = 4,
                            Director = "Some Guy",
                            Edited = false,
                            Lent = "",
                            Notes = "Such a great movie",
                            Rating = "PG",
                            Title = "Pocahontus",
                            Year = (ushort)1990
                        },
                        new
                        {
                            AppId = 3,
                            CategoryId = 4,
                            Director = "Some Guy",
                            Edited = false,
                            Lent = "",
                            Notes = "Love the frogs",
                            Rating = "PG",
                            Title = "Princess and the Frog",
                            Year = (ushort)2010
                        });
                });

            modelBuilder.Entity("mission4.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("mission4.Models.AddFilmModel", b =>
                {
                    b.HasOne("mission4.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
