﻿// <auto-generated />
using System;
using Generations.DA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Generations.DA.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.CreatedPokemons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ability")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Happiness")
                        .HasColumnType("int");

                    b.Property<bool>("IsShiny")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamsId");

                    b.ToTable("pokemons", (string)null);
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Evs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AttackValue")
                        .HasColumnType("int");

                    b.Property<int>("CreatedPokemonId")
                        .HasColumnType("int");

                    b.Property<int>("DefenseValue")
                        .HasColumnType("int");

                    b.Property<int>("HpValue")
                        .HasColumnType("int");

                    b.Property<int>("SpecialAttackValue")
                        .HasColumnType("int");

                    b.Property<int>("SpecialDefenseValue")
                        .HasColumnType("int");

                    b.Property<int>("SpeedValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedPokemonId")
                        .IsUnique();

                    b.ToTable("evs", (string)null);
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreatedPokemonId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CreatedPokemonId")
                        .IsUnique();

                    b.ToTable("items", (string)null);
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Ivs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AttackValue")
                        .HasColumnType("int");

                    b.Property<int>("CreatedPokemonId")
                        .HasColumnType("int");

                    b.Property<int>("DefenseValue")
                        .HasColumnType("int");

                    b.Property<int>("HpValue")
                        .HasColumnType("int");

                    b.Property<int>("SpecialAttackValue")
                        .HasColumnType("int");

                    b.Property<int>("SpecialDefenseValue")
                        .HasColumnType("int");

                    b.Property<int>("SpeedValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedPokemonId")
                        .IsUnique();

                    b.ToTable("ivs", (string)null);
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Moves", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("CreatedPokemonsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CreatedPokemonsId");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("Generations.DA.Entities.Teams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("pokemon_teams", (string)null);
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.CreatedPokemons", b =>
                {
                    b.HasOne("Generations.DA.Entities.Teams", null)
                        .WithMany("Team")
                        .HasForeignKey("TeamsId");
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Evs", b =>
                {
                    b.HasOne("Generations.DA.Entities.Pokemon.CreatedPokemons", "CreatedPokemon")
                        .WithOne("Evs")
                        .HasForeignKey("Generations.DA.Entities.Pokemon.Evs", "CreatedPokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedPokemon");
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Items", b =>
                {
                    b.HasOne("Generations.DA.Entities.Pokemon.CreatedPokemons", "CreatedPokemon")
                        .WithOne("HeldItem")
                        .HasForeignKey("Generations.DA.Entities.Pokemon.Items", "CreatedPokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedPokemon");
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Ivs", b =>
                {
                    b.HasOne("Generations.DA.Entities.Pokemon.CreatedPokemons", "CreatedPokemon")
                        .WithOne("Ivs")
                        .HasForeignKey("Generations.DA.Entities.Pokemon.Ivs", "CreatedPokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedPokemon");
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.Moves", b =>
                {
                    b.HasOne("Generations.DA.Entities.Pokemon.CreatedPokemons", null)
                        .WithMany("Moves")
                        .HasForeignKey("CreatedPokemonsId");
                });

            modelBuilder.Entity("Generations.DA.Entities.Pokemon.CreatedPokemons", b =>
                {
                    b.Navigation("Evs")
                        .IsRequired();

                    b.Navigation("HeldItem")
                        .IsRequired();

                    b.Navigation("Ivs")
                        .IsRequired();

                    b.Navigation("Moves");
                });

            modelBuilder.Entity("Generations.DA.Entities.Teams", b =>
                {
                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
