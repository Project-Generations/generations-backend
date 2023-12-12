using Generations.TeamManager.Interfaces;
using TeamModel = Generations.TeamManager.Models.Team;

namespace Generations.TeamManager.Services
{
    public class TeamService : ITeamService
    {
        private ITeam iTeam;

        public TeamService(ITeam iTeam)
        {
            this.iTeam = iTeam;
        }

        public void CreateTeam(TeamModel team)
        {
            throw new NotImplementedException();
        }

        public TeamModel GetTeamById(int teamId)
        {
            TeamModel team = iTeam.GetTeamById(teamId);
            return team;
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
