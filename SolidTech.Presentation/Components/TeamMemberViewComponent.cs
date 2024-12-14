using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Components
{
    public class TeamMemberViewComponent : ViewComponent
    {
        ITeamMemberService _teamMemberService;

        public TeamMemberViewComponent(ITeamMemberService teamMemberService)
        {
            _teamMemberService = teamMemberService;
        }


        public IViewComponentResult Invoke()
        {
            var team_members = _teamMemberService.TeamMembers();



            return View(team_members);
        }
    }
}
