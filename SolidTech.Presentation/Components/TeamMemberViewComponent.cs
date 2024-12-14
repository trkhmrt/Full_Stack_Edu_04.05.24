using Microsoft.AspNetCore.Mvc;

namespace SolidTech.Presentation.Components
{
    public class TeamMemberViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
