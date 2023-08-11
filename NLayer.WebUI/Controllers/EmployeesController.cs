using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.EmployeesDtos;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _employeesService;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeesService employeesService, IMapper mapper)
        {
            _employeesService = employeesService;
            _mapper = mapper;
        }

        // Tüm çalışanları asenkron olarak veritabanından çeker, EmployeesDto tipine dönüştürerek View'a döndürür.
        public async Task<IActionResult> Index()
        {
            // Tüm çalışanları asenkron olarak veritabanından çeker.
            var employees = await _employeesService.GetAllAsycn();
            // Çalışanları EmployeesDto listesine dönüştürür.
            var employeesDto = _mapper.Map<List<EmployeesDto>>(employees);

            // EmployeesDto listesini Index view'ına döndürür.
            return View(employeesDto);
        }

        // Yeni bir çalışan oluşturma sayfasını döndürür.
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            // Çalışan oluşturma sayfasını döndürür.
            return View();
        }

        // HTTP POST isteği ile çalışan oluşturma işlemini gerçekleştirir.
        [HttpPost]
        public async Task<IActionResult> Create(EmployeesDto employeesDto, IFormFile file)
        {
            // Gelen EmployeesDto null değilse:
            if (employeesDto != null)
            {
                // Çalışanın oluşturulma tarihini şu anki zamana ayarlar.
                employeesDto.CreatedDate = DateTime.Now;
                // Çalışanın resim URL'sini dosya adı olarak ayarlar.
                if (file!=null)
                {
                    employeesDto.ImageUrl = file.FileName;

                }

                // EmployeesDto'yu Employees tipine dönüştürerek veritabanına ekler.
                var employee = await _employeesService.AddAsycn(_mapper.Map<Employees>(employeesDto));
                var employeeDto = _mapper.Map<EmployeesDto>(employee);
                // Dosya null değilse:
                if (file != null)
                {
                    // Dosyayı uygun klasöre kaydeder.
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\cork-v3.8.0\\Employees-Foto", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                // Index sayfasına yönlendirme yapar.
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                return RedirectToAction("Index", "Employees");
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Employees");
        }

        // Belirli bir çalışanı siler ve ardından Index sayfasına yönlendirme yapar.
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            // ID'ye göre çalışanı veritabanından alır.
            var employee = await _employeesService.GetByIdAsycn(id);
            // Çalışan null değilse:
            if (employee != null)
            {
                // Çalışanı veritabanından siler.
                await _employeesService.RemoveAsycn(employee);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                // Index sayfasına yönlendirme yapar.
                return RedirectToAction("Index", "Employees");
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Employees");
        }

        // Birden fazla çalışanı toplu olarak siler ve ardından Index sayfasına yönlendirme yapar.
        [HttpPost]
        public async Task<IActionResult> BulkDelete(int[] Employees)
        {
            // Çalışanlar null değilse:
            if (Employees != null)
            {
                // Her bir çalışanı alıp siler.
                foreach (var item in Employees)
                {
                    var employee = await _employeesService.GetByIdAsycn(item);
                    // Çalışan null değilse:
                    if (employee != null)
                        await _employeesService.RemoveAsycn(employee);
                }
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                // Index sayfasına yönlendirme yapar.
                return RedirectToAction("Index", "Employees");
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Employees");
        }



        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var values = await _employeesService.GetByIdAsycn(id);
            var valuesDto = _mapper.Map<EmployeesDto>(values);
            return View(valuesDto);
        }

        [HttpGet]


        // HTTP POST isteği ile çalışan güncelleme işlemini gerçekleştirir.
        [HttpPost]
        public async Task<IActionResult> Update(EmployeesDto employeesDto, IFormFile file)
        {
            // Güncellenecek çalışanı ID'ye göre veritabanından alır.
            var employee = await _employeesService.GetByIdAsycn(employeesDto.Id);

            if (file != null)
            {
                // Dosyayı uygun klasöre kaydeder.
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\cork-v3.8.0\\Employees-Foto", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            // Çalışan null değilse:
            if (employee != null)
            {
                // Çalışanın özelliklerini günceller.
                employee.TCKN = employeesDto.TCKN;
                employee.Name = employeesDto.Name;
                employee.Surname = employeesDto.Surname;
                employee.Email = employeesDto.Email;
                employee.Phone = employeesDto.Phone;
                employee.Salary = employeesDto.Salary;
                employee.Location = employeesDto.Location;
                employee.StartedDate = employeesDto.StartedDate;
                employee.FinishDate = employeesDto.FinishDate;
                employee.DepartmentId = employeesDto.DepartmentId;
                employee.Mother = employeesDto.Mother;
                employee.Father = employeesDto.Father;
                employee.UrgentPerson = employeesDto.UrgentPerson;
                employee.UrgentPhone = employeesDto.UrgentPhone;
                employee.Address = employeesDto.Address;
                employee.ImageUrl = file.FileName;
                employee.Condition = employeesDto.Condition;
                employee.UpdatedDate = employeesDto.UpdatedDate;

                // Güncellenen çalışanı veritabanına kaydeder.
                await _employeesService.UpdateAsycn(employee);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                // Index sayfasına yönlendirme yapar.
                return RedirectToAction("Index", "Employees");
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Employees");
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            // Tüm öğrencileri veritabanından alır.
            var employees = await _employeesService.GetByIdAsycn(id);
            // JSON formatına dönüştürür.
            var jsonEmployee = JsonConvert.SerializeObject(employees);
            // JSON formatındaki öğrenciyi döndürür.
            return Json(jsonEmployee);
        }


    }

}
