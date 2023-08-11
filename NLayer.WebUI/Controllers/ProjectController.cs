using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.ProjectDtos;
using NLayer.Core.DTOs.ProjectEmployeesDto;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;
using Project = NLayer.Core.Concreate.Project;

namespace NLayer.WebUI.Controllers
{
    public class ProjectController : Controller
    {

        private readonly IProjectService _projectService;
        private readonly IProjectEmployeesService _projectEmployeesService;
        private readonly IEmployeesService _employeesService;
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public ProjectController(IDepartmentService departmentService, IMapper mapper, IProjectService projectService, IEmployeesService employeesService, IProjectEmployeesService projectEmployeesService)
        {
            _departmentService=departmentService;
            _mapper=mapper;
            _projectService=projectService;
            _employeesService=employeesService;
            _projectEmployeesService=projectEmployeesService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _projectService.GetWithEmployeesList();

            var valuesDto = _mapper.Map<List<GetWithEmployeesListDto>>(values);
            DateTime now = DateTime.Now;
            foreach (var item in valuesDto)
            {
                item.ComplationRate = Convert.ToInt32(item.ComplationRate);
                int dayDifference = (item.EndDate - now).Days;
                item.RemainingTime = dayDifference;
            }

            return View(valuesDto);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(ProjectDto projectDto)
        {

            if (projectDto != null)
            {
                projectDto.CreatedDate = DateTime.Now;
                var values = await _projectService.AddAsycn(_mapper.Map<Project>(projectDto));
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });

                return RedirectToAction("Index", "Project");

            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {

            var project = await _projectService.GetByIdAsycn(id);
            project.ComplationRate = Convert.ToInt32(project.ComplationRate);
            // JSON formatına dönüştürür.
            var jsonProject = JsonConvert.SerializeObject(project);
            // JSON formatındaki öğrenciyi döndürür.
            return Json(jsonProject);

        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _projectService.GetByIdAsycn(id);
            if (values!=null)
            {
                await _projectService.RemoveAsycn(values);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                return RedirectToAction("Index", "Project");
            }

            return RedirectToAction("Index", "Project");
        }


        [HttpPost]
        public async Task<IActionResult> Update(ProjectDto projectDto)
        {
            var values = await _projectService.GetByIdAsycn(projectDto.Id);
            if (values!=null)
            {
                values.Title = projectDto.Title;
                values.Description = projectDto.Description;
                values.ProjectManager = projectDto.ProjectManager;
                values.ComplationRate= Convert.ToDecimal(projectDto.ComplationRate);
                values.UpdatedDate = DateTime.Now;
                values.Condition = projectDto.Condition;

                await _projectService.UpdateAsycn(values);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                return RedirectToAction("Index", "Project");
            }

            return RedirectToAction("Index", "Project");
        }

        [HttpPost]
        public async Task<IActionResult> CreateProjectEmployees(int ProjectId, int[] SelectedIds)
        {

            foreach (var item in SelectedIds)
            {
                var values = new ProjectEmployeesDto()
                {
                    ProjectId = ProjectId,
                    EmployeesId = item
                };

                await _projectEmployeesService.AddAsycn(_mapper.Map<ProjectEmployees>(values));
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });

            }
            return RedirectToAction("Index", "Projcet");

        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeesList()
        {
            var employees = await _employeesService.GetAllAsycn();
            var employeeDataList = employees.Select(e => new
            {
                Id = e.Id,
                Name = e.Name,
                Surname = e.Surname,
                ImageUrl = e.ImageUrl
            }).ToList();


            // JSON formatına dönüştürür.
            var jsonEmployeesList = JsonConvert.SerializeObject(employeeDataList);
            // JSON formatındaki öğrenciyi döndürür.
            return Json(jsonEmployeesList);
        }
    }
}
