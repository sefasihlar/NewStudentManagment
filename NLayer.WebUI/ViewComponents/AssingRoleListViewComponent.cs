using Microsoft.AspNetCore.Mvc;

namespace NLayer.WebUI.ViewComponents
{
    public class AssingRoleListViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
