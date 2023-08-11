using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.StudentDtod;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        // Tüm öğrencileri, sınıf ve öğrenci listesiyle birlikte alır ve Index view'ına döndürür.
        public async Task<IActionResult> Index()
        {
            // Tüm öğrencileri, sınıf ve öğrenci listesiyle birlikte alır.
            var students = await _studentService.GetWithClassStudentList();
            // Index view'ına öğrencileri döndürür.
            return View(students);
        }

        // Yeni bir öğrenci oluşturmak için Create view'ını döndürür.
        public async Task<IActionResult> Create()
        {
            // Create view'ını döndürür.
            return View();
        }

        // HTTP POST isteği ile yeni bir öğrenci oluşturur.
        [HttpPost]
        public async Task<IActionResult> Create(StudentDto studentDto)
        {
            // StudentDto'yu Student tipine dönüştürerek veritabanına ekler.
            var values = await _studentService.AddAsycn(_mapper.Map<Student>(studentDto));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Student");
        }

        // Belirli bir öğrencinin detaylarını ID'ye göre alır ve Detail view'ını döndürür.
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            // ID'ye göre öğrenciyi veritabanından alır.
            var student = await _studentService.GetByIdAsycn(id);
            // StudentDto'ya dönüştürerek Detail view'ına döndürür.
            var values = _mapper.Map<StudentDto>(student);
            // Detail view'ını döndürür.
            return View(values);
        }

        // Belirli bir öğrenciyi günceller.
        [HttpPost]
        public async Task<IActionResult> Update(StudentDto studentDto)
        {
            // ID'ye göre öğrenciyi veritabanından alır.
            var student = await _studentService.GetByIdAsycn(studentDto.Id);

            // Öğrenci varsa güncelleme işlemlerini yapar.
            if (student != null)
            {
                student.StudentIdentity = studentDto.StudentIdentity;
                student.Name = studentDto.Name;
                student.SurName = studentDto.SurName;
                student.SchoolClass = studentDto.SchoolClass;
                student.School = studentDto.School;
                student.ClassId = studentDto.ClassId;
                student.Gender = studentDto.Gender;
                student.GuardianIdentity = studentDto.GuardianIdentity;
                student.GuardianName = studentDto.GuardianName;
                student.GuardianSurName = studentDto.GuardianSurName;
                student.GuardianJob = studentDto.GuardianJob;
                student.GuardianPhone = studentDto.GuardianPhone;
                student.GuardianEmail = studentDto.GuardianEmail;
                student.Condition = studentDto.Condition;
                student.Adress = studentDto.Adress;
                student.Price = studentDto.Price;
                student.UpdatedDate = DateTime.Now;
            }

            // Öğrenciyi günceller.
            await _studentService.UpdateAsycn(student);
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });

            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Student");
        }

        // Belirli bir öğrenciyi ID'ye göre veritabanından alır ve JSON formatında döndürür.
        [HttpGet]
        public async Task<IActionResult> GetStudentById(int id)
        {
            // Tüm öğrencileri veritabanından alır.
            var students = await _studentService.GetAllAsycn();
            // ID'ye göre filtrelenmiş öğrenciyi bulur.
            var findStudent = students.FirstOrDefault(x => x.Id == id);
            // JSON formatına dönüştürür.
            var jsonStudent = JsonConvert.SerializeObject(findStudent);
            // JSON formatındaki öğrenciyi döndürür.
            return Json(jsonStudent);
        }

        // Belirli bir öğrenciyi siler ve ardından Index sayfasına yönlendirme yapar.
        public async Task<IActionResult> Delete(int id)
        {
            // ID'ye göre öğrenciyi veritabanından alır.
            var student = await _studentService.GetByIdAsycn(id);
            // Öğrenciyi veritabanından siler.
            await _studentService.RemoveAsycn(_mapper.Map<Student>(student));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Student");
        }
    }

}
