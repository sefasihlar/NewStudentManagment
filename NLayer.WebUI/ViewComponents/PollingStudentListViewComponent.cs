﻿using Microsoft.AspNetCore.Mvc;

namespace NLayer.WebUI.ViewComponents
{
    public class PollingStudentListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
