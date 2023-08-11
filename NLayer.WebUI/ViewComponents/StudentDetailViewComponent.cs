using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.WebUI.ViewComponents
{
    public class StudentDetailViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new StudentDto()
            {

            });
        }
    }
}
