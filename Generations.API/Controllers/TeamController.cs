using Generations.API.DTOs;
using Generations.TeamManager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TeamModel = Generations.TeamManager.Models.Team;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        // GET: api/<TeamController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TeamController>/5
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

        // POST api/<TeamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TeamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
