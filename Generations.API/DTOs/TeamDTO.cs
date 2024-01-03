using TeamModel = Generations.TeamManager.Models.Team;

namespace Generations.API.DTOs
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }

        public TeamDTO(TeamModel teamModel)
        {
            this.Id = teamModel.Id;
            this.Name = teamModel.Name;
            this.Format = teamModel.Format;
        }
    }
}
