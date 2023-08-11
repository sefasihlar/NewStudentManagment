using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.ClassDtos;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{
    public class ClassListViewComponent : ViewComponent
    {
        private readonly IClassService _classService;
        private readonly IClassDayService _classDayService;
        private readonly IMapper _mapper;

        public ClassListViewComponent(IClassService classService, IClassDayService classDayService, IMapper mapper)
        {
            _classService = classService;
            _classDayService = classDayService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var classes = await _classService.GetAllAsycn();
            var classDtos = _mapper.Map<List<ClassDto>>(classes.ToList());
            return View(classDtos);
        }
    }

}
