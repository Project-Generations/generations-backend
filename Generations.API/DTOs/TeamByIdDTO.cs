using Generations.PokemonManager.Models;
using TeamModel = Generations.TeamManager.Models.Team;

namespace Generations.API.DTOs
{
    public class TeamByIdDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public List<CreatedPokemon> PokemonTeam { get; set; } = new();

        public TeamByIdDTO(TeamModel teamModel)
        {
            this.Id = teamModel.Id;
            this.Name = teamModel.Name;
            this.Format = teamModel.Format;
            this.PokemonTeam = teamModel.PokemonTeam;
        }
    }
}
