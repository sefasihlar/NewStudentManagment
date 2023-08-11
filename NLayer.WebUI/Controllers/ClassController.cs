using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.ClassDtos;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;
        private readonly IClassDayService _classDayService;
        private readonly IMapper _mapper;

        public ClassController(IClassService classService, IMapper mapper, IClassDayService classDayService)
        {
            _classService = classService;
            _mapper = mapper;
            _classDayService = classDayService;
        }

        // Tüm sınıfları asenkron olarak veritabanından çeker, ClassDto tipine dönüştürerek Index view'ına döndürür.
        public async Task<IActionResult> Index()
        {
            // Tüm sınıfları veritabanından çeker.
            var classes = await _classService.GetAllAsycn();
            // ClassDto'ya dönüştürür.
            var classDtos = _mapper.Map<List<ClassDto>>(classes.ToList());
            // Index view'ına sınıf listesini döndürür.
            return View(classDtos);
        }

        // Yeni bir sınıf oluşturma sayfasını döndürür.
        public async Task<IActionResult> Create()
        {
            // Create view'ını döndürür.
            return View();
        }

        // HTTP POST isteği ile yeni bir sınıf oluşturur.
        [HttpPost]
        public async Task<IActionResult> Create(ClassDto classDto, IFormFile file, int[] DayIds)
        {
            // Eğer dosya yüklendiyse, sınıfın ImageUrl özelliğine dosya adını atar.
            if (file != null)
            {
                classDto.ImageUrl = file.FileName;
            }

            // Sınıfı Class tipine dönüştürerek veritabanına ekler ve oluşturulan sınıfın değerlerini alır.
            var createdClass = await _classService.AddAsycn(_mapper.Map<Class>(classDto));

            // Eğer dosya yüklendiyse, dosyayı sunucudaki uygun klasöre kaydeder.
            if (file != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\cork-v3.8.0\\Class-Foto", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            // Seçilen günleri sınıf günleri tablosuna ekler.
            foreach (var dayId in DayIds)
            {
                var classDay = new ClassDay()
                {
                    ClassId = createdClass.Id,
                    DayId = dayId
                };

                await _classDayService.AddAsycn(classDay);

                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
            }

            // Sınıf oluşturma işlemi tamamlandıktan sonra Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Class");
        }

        // Belirli bir sınıfın detaylarını asenkron olarak veritabanından çeker, ClassDto tipine dönüştürerek Detail view'ına döndürür.
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            // ID'ye göre sınıfı veritabanından çeker.
            var classEntity = await _classService.GetByIdAsycn(id);
            // ClassDto'ya dönüştürür.
            var classDto = _mapper.Map<ClassDto>(classEntity);
            // Detail view'ına sınıf detaylarını döndürür.
            return View(classDto);
        }

        // Belirli bir sınıfı siler ve ardından Index sayfasına yönlendirme yapar.
        public async Task<IActionResult> Delete(int id)
        {
            // ID'ye göre sınıfı veritabanından çeker.
            var classEntity = await _classService.GetByIdAsycn(id);
            // Sınıfı Class tipine dönüştürür.
            var classDto = _mapper.Map<Class>(classEntity);
            // Sınıfı veritabanından siler.
            await _classService.RemoveAsycn(classDto);
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Class");
        }



    }


}

