using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Generations.DA.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pokemon_teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Format = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon_teams", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Happiness = table.Column<int>(type: "int", nullable: false),
                    Ability = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsShiny = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Gender = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pokemons_pokemon_teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "pokemon_teams",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "evs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HpValue = table.Column<int>(type: "int", nullable: false),
                    AttackValue = table.Column<int>(type: "int", nullable: false),
                    DefenseValue = table.Column<int>(type: "int", nullable: false),
                    SpecialAttackValue = table.Column<int>(type: "int", nullable: false),
                    SpecialDefenseValue = table.Column<int>(type: "int", nullable: false),
                    SpeedValue = table.Column<int>(type: "int", nullable: false),
                    CreatedPokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_evs_pokemons_CreatedPokemonId",
                        column: x => x.CreatedPokemonId,
                        principalTable: "pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedPokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_items_pokemons_CreatedPokemonId",
                        column: x => x.CreatedPokemonId,
                        principalTable: "pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ivs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HpValue = table.Column<int>(type: "int", nullable: false),
                    AttackValue = table.Column<int>(type: "int", nullable: false),
                    DefenseValue = table.Column<int>(type: "int", nullable: false),
                    SpecialAttackValue = table.Column<int>(type: "int", nullable: false),
                    SpecialDefenseValue = table.Column<int>(type: "int", nullable: false),
                    SpeedValue = table.Column<int>(type: "int", nullable: false),
                    CreatedPokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ivs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ivs_pokemons_CreatedPokemonId",
                        column: x => x.CreatedPokemonId,
                        principalTable: "pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedPokemonsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_pokemons_CreatedPokemonsId",
                        column: x => x.CreatedPokemonsId,
                        principalTable: "pokemons",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_evs_CreatedPokemonId",
                table: "evs",
                column: "CreatedPokemonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_items_CreatedPokemonId",
                table: "items",
                column: "CreatedPokemonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ivs_CreatedPokemonId",
                table: "ivs",
                column: "CreatedPokemonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Moves_CreatedPokemonsId",
                table: "Moves",
                column: "CreatedPokemonsId");

            migrationBuilder.CreateIndex(
                name: "IX_pokemons_TeamsId",
                table: "pokemons",
                column: "TeamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evs");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "ivs");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "pokemons");

            migrationBuilder.DropTable(
                name: "pokemon_teams");
        }
    }
}
