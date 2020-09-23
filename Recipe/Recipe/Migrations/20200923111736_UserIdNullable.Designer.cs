﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipe.Models;

namespace Recipe.Migrations
{
    [DbContext(typeof(recipesContext))]
    [Migration("20200923111736_UserIdNullable")]
    partial class UserIdNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Recipe.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<string>("IngredientAmount")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("IngredientName")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("IngredientId")
                        .HasName("PK__Ingredie__BEAEB25AF59F733E");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Recipe.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("RecipeDescription")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("RecipeName")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId")
                        .HasName("PK__Recipes__FDD988B02F32FFD7");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Recipe.Models.Step", b =>
                {
                    b.Property<int>("StepId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("StepDescription")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("StepId")
                        .HasName("PK__Steps__2434335752018F14");

                    b.HasIndex("RecipeId");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("Recipe.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("UserPassword")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CC4CB50B52E6");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Recipe.Models.Ingredient", b =>
                {
                    b.HasOne("Recipe.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__Ingredien__Recip__286302EC");
                });

            modelBuilder.Entity("Recipe.Models.Recipe", b =>
                {
                    b.HasOne("Recipe.Models.User", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Recipes__UserId__25869641")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recipe.Models.Step", b =>
                {
                    b.HasOne("Recipe.Models.Recipe", "Recipe")
                        .WithMany("Steps")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__Steps__RecipeId__2B3F6F97");
                });
#pragma warning restore 612, 618
        }
    }
}
