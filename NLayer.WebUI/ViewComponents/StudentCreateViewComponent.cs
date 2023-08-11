using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.WebUI.ViewComponents
{
    public class StudentCreateViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new StudentDto()
            {

            });
        }
    }
}
