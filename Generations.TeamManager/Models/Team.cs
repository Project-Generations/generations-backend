using Generations.PokemonManager.Models;

namespace Generations.TeamManager.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public List<CreatedPokemon> PokemonTeam { get; set; } = new();
    }
}
