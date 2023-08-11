
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.DepartmentDtos;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{

    public class DepartmentListViewComponent : ViewComponent
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DepartmentListViewComponent(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService=departmentService;
            _mapper=mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _departmentService.GetAllAsycn();
            var valuesDto = _mapper.Map<List<DepartmentDto>>(values);
            return View(valuesDto);
        }
    }
}
