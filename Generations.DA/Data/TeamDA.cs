using Generations.TeamManager.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using CreatedPokemonEntity = Generations.DA.Entities.Pokemon.CreatedPokemons;
using TeamModel = Generations.TeamManager.Models.Team;

namespace Generations.DA.Data
{
    public class TeamDA : ITeam
    {
        private readonly DataContext _dataContext;

        public TeamDA(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateTeam(TeamModel team)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TeamModel> GetTeam()
        {
            throw new NotImplementedException();
        }

        public TeamModel GetTeamById(int teamId)
        {
            using (_dataContext)
            {
                try
                {
                    var _team = _dataContext.Teams.Include(t => t.Team).Single(t => t.Id == teamId);

                    TeamModel team = new()
                    {
                        Id = _team.Id,
                        Name = _team.Name,
                        Format = _team.Format,
                        PokemonTeam = _team.Team.Select(CreatedPokemonEntity.ConvertCreatedPokemonsEntity).ToList(),
                    };

                    return team;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }
        }

        public IEnumerable<TeamModel> GetTeams()
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam(int animeId, TeamModel team)
        {
            throw new NotImplementedException();
        }
    }
}
