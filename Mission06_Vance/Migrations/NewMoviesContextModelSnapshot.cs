﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Vance.Models;

#nullable disable

namespace Mission06_Vance.Migrations
{
    [DbContext(typeof(NewMoviesContext))]
    partial class NewMoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Mission06_Vance.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("MovieEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieLentTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieNotes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
