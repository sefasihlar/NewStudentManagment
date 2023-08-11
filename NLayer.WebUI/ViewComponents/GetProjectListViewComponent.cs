using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.ProjectDtos;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{
    public class GetProjectListViewComponent : ViewComponent
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public GetProjectListViewComponent(IProjectService projectService, IMapper mapper)
        {
            _projectService=projectService;
            _mapper=mapper;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _projectService.GetWithEmployeesList();
            var lastThreeItems = values.TakeLast(3).ToList();

            var valuesDto = _mapper.Map<List<GetWithEmployeesListDto>>(lastThreeItems);
            DateTime now = DateTime.Now;
            foreach (var item in valuesDto)
            {
                item.ComplationRate = Convert.ToInt32(item.ComplationRate);
                int dayDifference = (item.EndDate - now).Days;
                item.RemainingTime = dayDifference;
            }

            return View(valuesDto);
        }
    }
}
