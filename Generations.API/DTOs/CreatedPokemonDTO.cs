using Generations.PokemonManager.Models;
using CreatedPokemonModel = Generations.PokemonManager.Models.CreatedPokemon;

namespace Generations.API.DTOs
{
    public class CreatedPokemonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Happiness { get; set; }
        public string Ability { get; set; } = string.Empty;
        public bool IsShiny { get; set; }
        public string Gender { get; set; } = string.Empty;
        public EvSpread EvSpread { get; set; }
        public IvSpread IvSpread { get; set; }
        public Item HeldItem { get; set; }

        public CreatedPokemonDTO(CreatedPokemonModel createdPokemonModel)
        {
            this.Id = createdPokemonModel.Id;
            this.Name = createdPokemonModel.Name;
            this.Level = createdPokemonModel.Level;
            this.Happiness = createdPokemonModel.Happiness;
            this.Ability = createdPokemonModel.Ability;
            this.IsShiny = createdPokemonModel.IsShiny;
            this.Gender = createdPokemonModel.Gender;
            this.EvSpread = createdPokemonModel.EvSpread;
            this.IvSpread = createdPokemonModel.IvSpread;
            this.HeldItem = createdPokemonModel.HeldItem;
        }
    }
}
