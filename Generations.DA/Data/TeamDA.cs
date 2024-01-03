using Generations.TeamManager.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using CreatedPokemonEntity = Generations.DA.Entities.Pokemon.CreatedPokemons;
using TeamEntity = Generations.DA.Entities.Teams;
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
            if (team != null)
            {
                TeamEntity _team = new()
                {
                    Id = team.Id,
                    Name = team.Name,
                    Format = team.Format
                };

                _dataContext.Teams.Add(_team);
                _dataContext.SaveChanges();
            }
            else
            {
                throw new Exception("Can't create the team, Team is empty");
            }
        }

        public void DeleteTeam(int teamId)
        {
            var team = _dataContext.Teams.Include(t => t.Team).Single(t => t.Id == teamId);

            if (team != null)
            {
                _dataContext.Teams.Remove(team);
                _dataContext.SaveChanges();
            }
            else
            {
                throw new Exception("This team doesn't exist or can't be deleted");
            }
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
            var _teams = _dataContext.Teams.Include(t => t.Team).ToList();
            List<TeamModel> teams = new();

            foreach (var team in _teams)
            {
                TeamModel teamModel = new()
                {
                    Id = team.Id,
                    Name = team.Name,
                    Format = team.Format,
                };

                teams.Add(teamModel);
            }

            return teams;
        }

        public void UpdateTeam(int animeId, TeamModel team)
        {
            throw new NotImplementedException();
        }
    }
}
