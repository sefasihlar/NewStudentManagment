using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.DepartmentDtos;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IEmployeesService _employeesService;
        private readonly IMapper _mapper;
        private readonly IDepartmentService _departmentService;


        public DepartmentController(IEmployeesService employeesService, IMapper mapper, IDepartmentService departmentService)
        {
            _employeesService = employeesService;
            _mapper = mapper;
            _departmentService=departmentService;
        }
        public async Task<IActionResult> Index()
        {
            var departments = await _departmentService.GetWithEmployeesList();
            return View(departments);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DepartmentDto departmentDto)
        {
            departmentDto.CreatedDate = DateTime.Now;

            var Department = await _departmentService.AddAsycn(_mapper.Map<Department>(departmentDto));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            var classesDto = _mapper.Map<DepartmentDto>(Department);
            return RedirectToAction("Index", "Department");
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var values = await _departmentService.GetByIdAsycn(id);
            if (values!=null)
            {
                await _departmentService.RemoveAsycn(values);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                return RedirectToAction("Index", "Department");
            }


            return RedirectToAction("Index", "Department");
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var department = await _departmentService.GetByIdAsycn(id);
            // JSON formatına dönüştürür.
            var jsonDepartment = JsonConvert.SerializeObject(department);
            // JSON formatındaki öğrenciyi döndürür.
            return Json(jsonDepartment);
        }

        [HttpPost]
        public async Task<IActionResult> Update(DepartmentDto departmentDto)
        {

            var values = await _departmentService.GetByIdAsycn(departmentDto.Id);
            if (values!=null)
            {
                values.Name = departmentDto.Name;
                values.Description = departmentDto.Description;
                values.DepartmentManager = departmentDto.DepartmentManager;
                values.UpdatedDate = DateTime.Now;

                await _departmentService.UpdateAsycn(values);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                return RedirectToAction("Index", "Department");
            }



            return RedirectToAction("Index", "Department");

        }
    }
}
