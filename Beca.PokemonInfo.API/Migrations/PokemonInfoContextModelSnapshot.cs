﻿// <auto-generated />
using Beca.PokemonInfo.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Beca.PokemonInfo.API.Migrations
{
    [DbContext(typeof(PokemonInfoContext))]
    partial class PokemonInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Beca.PokemonInfo.API.Entities.Attack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PokemonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PokemonId");

                    b.ToTable("Attacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Placaje causa daño y no tiene ningún efecto secundario. Este movimiento tiene una potencia de 35 y una precisión del 95%.",
                            Name = "Placaje",
                            PokemonId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Látigo cepa causa daño y no tiene ningún efecto secundario. El movimiento tiene una potencia de 35 y 10 PP.",
                            Name = "Látigo Cepa",
                            PokemonId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Látigo baja en un nivel la defensa del oponente. En combates dobles y triples afecta a todos los oponentes adyacentes. No afecta a Pokémon con las habilidades cuerpo puro, humo blanco o sacapecho.\r\n\r\n",
                            Name = "Látigo",
                            PokemonId = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Lanzallamas causa daño y tiene una probabilidad del 10% de quemar al objetivo. Lanzallamas tiene una potencia de 95.\r\n",
                            Name = "Lanzallamas",
                            PokemonId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Arañazo causa daño y no tiene ningún efecto secundario.",
                            Name = "Arañazo",
                            PokemonId = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "Pistola agua causa daño y no tiene ningún efecto secundario.",
                            Name = "Pistola Agua",
                            PokemonId = 3
                        });
                });

            modelBuilder.Entity("Beca.PokemonInfo.API.Entities.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pokemon tipo planta de la primera generacion, te lanza un látigo cepa y te deja moratón",
                            Name = "Bulbasaur"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Pokemon tipo de agua de la primera generación, es el pokemon favorito de los verdaderos amantes de pokemon.",
                            Name = "Charmander"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Pokemon tipo de agua de la primera generación, tiene una concha a su espalda y está siempre calmado.",
                            Name = "Squirtle"
                        });
                });

            modelBuilder.Entity("Beca.PokemonInfo.API.Entities.Attack", b =>
                {
                    b.HasOne("Beca.PokemonInfo.API.Entities.Pokemon", "Pokemon")
                        .WithMany("Attacks")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Beca.PokemonInfo.API.Entities.Pokemon", b =>
                {
                    b.Navigation("Attacks");
                });
#pragma warning restore 612, 618
        }
    }
}
