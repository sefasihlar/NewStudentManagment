using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.PollingDtos;
using NLayer.Core.DTOs.StudentPollingDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class PollingController : Controller
    {
        private readonly IStudentPollingService _studentPollingService;
        private readonly IPollingService _pollingService;
        private readonly IMapper _mapper;
        private readonly IStudentService _studentService;

        public PollingController(IPollingService pollingService, IMapper mapper, IStudentService studentService, IStudentPollingService studentPollingService)
        {
            _pollingService = pollingService;
            _mapper = mapper;
            _studentService = studentService;
            _studentPollingService = studentPollingService;
        }

        // Tüm yoklamaları, sınıf bilgileriyle birlikte alır ve Index view'ına döndürür.
        public async Task<IActionResult> Index()
        {
            // Tüm yoklamaları, sınıf bilgileriyle birlikte alır.
            var polling = await _pollingService.GetWithClassList();
            // Index view'ına yoklamaları döndürür.
            return View(polling);
        }

        // Belirli bir yoklamayı ID'ye göre alır ve GetById view'ını döndürür.
        public IActionResult GetById(int id)
        {
            // GetById view'ını döndürür.
            return View();
        }

        // HTTP POST isteği ile yeni bir yoklama oluşturur.
        [HttpPost]
        public async Task<IActionResult> Create(PollingDto pollingDto)
        {
            // Oluşturulan yoklamanın oluşturma tarihini şu anki zamana ayarlar.
            pollingDto.CreatedDate = DateTime.Now;
            // PollingDto'yu Polling tipine dönüştürerek veritabanına ekler.
            var values = await _pollingService.AddAsycn(_mapper.Map<Polling>(pollingDto));
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Polling");
        }

        // Belirli bir öğrenciyi yoklamaya ekler.
        public async Task<IActionResult> AddToStudent(StudentPollingDto studentDto, int[] StudentIds)
        {
            // Öğrenci ID'leri null değilse:
            if (StudentIds != null)
            {
                // Her bir öğrenci ID'si için öğrenci yoklama kaydı oluşturur.
                foreach (var item in StudentIds)
                {
                    var values = new StudentPollingDto()
                    {
                        PollingId = studentDto.PollingId,
                        StudentId = item
                    };

                    // Oluşturulan öğrenci yoklama kaydını veritabanına ekler.
                    if (values != null)
                    {
                        await _studentPollingService.AddAsycn(_mapper.Map<StudentPolling>(values));
                    }
                }
            }
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Polling");
        }

        // Belirli bir yoklamayı siler ve ardından Index sayfasına yönlendirme yapar.
        public async Task<IActionResult> Delete(int id)
        {
            // ID'ye göre yoklamayı veritabanından alır.
            var polling = await _pollingService.GetByIdAsycn(id);
            // Yoklamayı veritabanından siler.
            await _pollingService.RemoveAsycn(_mapper.Map<Polling>(polling));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Polling");
        }

        // Belirli bir yoklamanın detaylarını JSON formatında döndürür.
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            // Tüm öğrenci yoklamalarını asenkron olarak veritabanından çeker.
            var values = await _studentPollingService.GetAllAsycn();
            // ID'ye göre filtrelenmiş öğrenci yoklamalarını alır.
            var filter = values.Where(x => x.PollingId == id).ToList();
            // JSON formatına dönüştürür.
            var jsonStudent = JsonConvert.SerializeObject(filter);
            // JSON formatındaki öğrenci yoklamalarını döndürür.
            return Json(jsonStudent);
        }

        // Belirli bir yoklamayı günceller.
        [HttpPost]
        public async Task<IActionResult> Update(StudentPollingDto studentDto, int[] StudentIds)
        {
            // Tüm öğrenci yoklamalarını almak için _studentPollingService kullanılıyor
            var allPollings = await _studentPollingService.GetAllAsycn();

            // studentDto'dan gelen yoklama ID'siyle eşleşen yoklamaları filtrelemek için LINQ kullanılıyor
            var filteredPollings = allPollings.Where(p => p.PollingId == studentDto.PollingId).ToList();

            // Filtrelenmiş yoklamaların her biri için öğrenci listesini güncellemek yerine,
            // önce mevcut kayıtları silip sonra yeni kayıtları ekliyoruz

            // Filtrelenmiş yoklamaların öğrenci kayıtlarını silmek için döngü kullanılıyor
            foreach (var polling in filteredPollings)
            {
                await _studentPollingService.RemoveAsycn(polling);
            }

            // Yeni öğrenci kayıtlarını eklemek için döngü kullanılıyor
            foreach (var studentId in StudentIds)
            {
                var newPolling = new StudentPolling
                {
                    PollingId = studentDto.PollingId,
                    StudentId = studentId
                };

                await _studentPollingService.AddAsycn(newPolling);
            }

            // Index sayfasına yönlendirme yapılıyor
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            return RedirectToAction("Index", "Polling");
        }

        // Belirli bir sınıfa ait öğrenci listesini JSON formatında döndürür.
        [HttpGet]
        public async Task<IActionResult> GetByPollingIdStudentList(int id)
        {
            // Tüm öğrencileri asenkron olarak veritabanından çeker.
            var students = await _studentService.GetAllAsycn();
            // ID'ye göre filtrelenmiş öğrenci listesini alır.
            var filteredStudents = students.Where(x => x.ClassId == id);
            // JSON formatına dönüştürür.
            var jsonStudent = JsonConvert.SerializeObject(filteredStudents);
            // JSON formatındaki öğrenci listesini döndürür.
            return Json(jsonStudent);
        }

        // Belirli bir yoklamaya ait öğrenci listesini getirir ve GetWithStudentList view'ını döndürür.
        [HttpGet]
        public async Task<IActionResult> GetWithStudentList(int id)
        {
            // Yoklama ID'siyle birlikte öğrenci listesini alır.
            var pollingStudents = await _studentPollingService.GetByPollingIdWithStudentList(id);
            // GetWithStudentList view'ını döndürür.
            return View(pollingStudents);
        }
    }




}
