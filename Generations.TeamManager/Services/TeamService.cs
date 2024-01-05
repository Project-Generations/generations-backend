using Generations.TeamManager.Interfaces;
using TeamModel = Generations.TeamManager.Models.Team;

namespace Generations.TeamManager.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeam iTeam;

        public TeamService(ITeam iTeam)
        {
            this.iTeam = iTeam;
        }

        public void CreateTeam(TeamModel team)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(int teamId)
        {
            iTeam.DeleteTeam(teamId);
        }

        public TeamModel GetTeamById(int teamId)
        {
            TeamModel team = iTeam.GetTeamById(teamId);
            return team;
        }

        public IEnumerable<TeamModel> GetTeams()
        {
            return iTeam.GetTeams();
        }

        public void UpdateTeam(int teamId, TeamModel team)
        {
            throw new NotImplementedException();
        }
    }
}
