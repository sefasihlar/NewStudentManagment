using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{
    public class PaymentListViewComponent : ViewComponent
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public PaymentListViewComponent(IStudentService studentervice, IMapper mapper, IClassDayService classDayService)
        {
            _studentService = studentervice;
            _mapper = mapper;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
