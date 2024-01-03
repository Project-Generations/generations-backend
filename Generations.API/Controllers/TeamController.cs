using Generations.API.DTOs;
using Generations.TeamManager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TeamModel = Generations.TeamManager.Models.Team;

namespace Generations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        readonly ITeamService teamService;
        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [HttpGet]
        public IEnumerable<TeamDTO> Get()
        {
            try
            {
                return teamService.GetTeams()
                    .Select(p => new TeamDTO(p))
                    .ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public TeamByIdDTO Get(int id)
        {
            try
            {
                TeamModel team = teamService.GetTeamById(id);
                TeamByIdDTO teamByIdDTO = new(team);

                return teamByIdDTO;
            }
            catch (Exception ex)
            {
                throw new Exception("Can't map data to DTO", ex);
            }
        }

        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            try
            {
                teamService.DeleteTeam(id);
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }
    }
}
