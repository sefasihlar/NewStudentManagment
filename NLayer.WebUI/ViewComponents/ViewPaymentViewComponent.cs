using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{
    public class ViewPaymentViewComponent : ViewComponent
    {
        private readonly IPaymentService _paymentService;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public ViewPaymentViewComponent(IPaymentService studentervice, IMapper mapper, IStudentService studentService)
        {
            _paymentService = studentervice;
            _mapper = mapper;
            _studentService = studentService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _paymentService.GetWithStudentList();
            var filter = values.Where(x => x.StudentId == ViewBag.StudentId).ToList();
            return View(filter);
        }
    }
}
