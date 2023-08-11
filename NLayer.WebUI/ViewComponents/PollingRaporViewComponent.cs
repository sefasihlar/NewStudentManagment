using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{
    public class PollingRaporViewComponent : ViewComponent
    {
        private readonly IStudentPollingService _studentPollingService;

        public PollingRaporViewComponent(IStudentPollingService studentPollingService)
        {
            _studentPollingService=studentPollingService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {


            var values = await _studentPollingService.GetByPollingIdWithStudentList(id);
            if (values!=null)
            {
                return View(values);
            }
            return View(values);
        }
    }
}
