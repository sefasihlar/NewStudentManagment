using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.DepartmentDtos;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{
    public class EmployeesListViewComponent : ViewComponent
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public EmployeesListViewComponent(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService=departmentService;
            _mapper=mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _departmentService.GetWithEmployeesList();
            var valuesDto = _mapper.Map<List<GetWithEmployeesDto>>(values);
            return View(valuesDto);
        }
    }
}
