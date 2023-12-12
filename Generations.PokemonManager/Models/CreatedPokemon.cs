namespace Generations.PokemonManager.Models
{
    public class CreatedPokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Happiness { get; set; }
        public string Ability { get; set; } = string.Empty;
        public bool IsShiny { get; set; }
        public string Gender { get; set; } = string.Empty;
        public Item HeldItem { get; set; } = new();
        public EvSpread EvSpread { get; set; } = new();
        public IvSpread IvSpread { get; set; } = new();
        public List<Move> Moves { get; set; } = new();
    }
}
