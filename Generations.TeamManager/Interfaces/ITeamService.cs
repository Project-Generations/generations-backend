using Generations.TeamManager.Models;

namespace Generations.TeamManager.Interfaces
{
    public interface ITeamService
    {
        public IEnumerable<Team> GetTeams();
        public Team GetTeamById(int teamId);
        public void CreateTeam(Team team);
        public void UpdateTeam(int animeId, Team team);
    }
}
