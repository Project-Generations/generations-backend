using Generations.PokemonManager.Models;
using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Entities.Pokemon
{
    public class CreatedPokemons
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Happiness { get; set; }
        public string Ability { get; set; } = string.Empty;
        public bool IsShiny { get; set; }
        public string Gender { get; set; } = string.Empty;
        public Ivs Ivs { get; set; } = new();
        public Evs Evs { get; set; } = new();
        public Items Item { get; set; } = new();
        public ICollection<Moves> Moves { get; set; } = new List<Moves>();

        public static CreatedPokemon ConvertCreatedPokemonsEntity(CreatedPokemons createdPokemonEntity)
        {
            CreatedPokemon createdPokemon = new()
            {
                Id = createdPokemonEntity.Id,
                Name = createdPokemonEntity.Name,
                Level = createdPokemonEntity.Level,
                Happiness = createdPokemonEntity.Happiness,
                Ability = createdPokemonEntity.Ability,
                IsShiny = createdPokemonEntity.IsShiny,
                Gender = createdPokemonEntity.Gender,
                HeldItem = createdPokemonEntity.Item.ConvertItemsEntity(createdPokemonEntity.Item),
                EvSpread = createdPokemonEntity.Evs.ConvertEvsEntity(createdPokemonEntity.Evs),
                IvSpread = createdPokemonEntity.Ivs.ConvertIvsEntity(createdPokemonEntity.Ivs),
            };

            return createdPokemon;
        }
    }
}
