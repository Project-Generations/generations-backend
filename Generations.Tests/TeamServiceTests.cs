using Generations.API.Controllers;
using Generations.TeamManager.Interfaces;
using Generations.TeamManager.Models;
using Moq;

namespace Generations.Tests
{
    [TestClass]
    public class TeamServiceTests
    {
        private Mock<ITeamService> TeamServiceMock = new Mock<ITeamService>();

        [TestMethod]
        public void TeamByIdTest_Method()
        {
            int TeamId = 1;
            string TeamName = "Test";
            string TeamFormat = "OU";

            Team TestTeam = new()
            {
                Id = TeamId,
                Name = TeamName,
                Format = TeamFormat,
            };

            TeamServiceMock.Setup(x => x.GetTeamById(TeamId)).Returns(TestTeam);

            var controller = new TeamController(TeamServiceMock.Object);
            var getTeamById = controller.Get(1);

            Assert.AreEqual(TeamId, getTeamById.Id);
            Assert.AreEqual(TeamName, getTeamById.Name);
            Assert.AreEqual(TeamFormat, getTeamById.Format);
        }

        [TestMethod]
        public void FailedToGetTeamByIdTest_Method()
        {
            int TeamId = 1;
            string TeamName = "Test";
            string TeamFormat = "OU";

            Team TestTeam = new()
            {
                Id = TeamId,
                Name = TeamName,
                Format = TeamFormat,
            };

            TeamServiceMock.Setup(x => x.GetTeamById(TeamId)).Returns(TestTeam);

            var controller = new TeamController(TeamServiceMock.Object);
            var getTeamById = controller.Get(2);

            Assert.ThrowsException<Exception>(getTeamById);
        }

        [TestMethod]
        public void GetTeamsTest_Method()
        {
            Team TestTeam = new()
            {
                Id = 1,
                Name = "Test",
                Format = "OU",
            };

            Team TestTeam2 = new()
            {
                Id = 2,
                Name = "TestTest",
                Format = "UU",
            };
            List<Team> teams = new() { TestTeam, TestTeam2 };

            TeamServiceMock.Setup(x => x.GetTeams()).Returns(teams);
            var controller = new TeamController(TeamServiceMock.Object);
            var getTeams = controller.Get();

            Assert.IsNotNull(getTeams);
        }

        [TestMethod]
        public void CreateTeamTest_Method()
        {
        }

        [TestMethod]
        public void DeleteTeamTest_Method()
        {
        }
    }
}
