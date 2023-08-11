using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.PaymentDtos;
using NLayer.Core.DTOs.StudentDtod;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public PaymentController(IPaymentService paymentService, IMapper mapper, IStudentService studentService)
        {
            _paymentService = paymentService;
            _mapper = mapper;
            _studentService = studentService;
        }

        // Ödeme görüntüleme sayfasını döndürür ve ilgili öğrenci bilgilerini alır.
        public async Task<IActionResult> PaymentView(int id)
        {
            // ID'ye göre öğrenciyi veritabanından alır.
            var student = await _studentService.GetByIdAsycn(id);
            // Öğrenciyi StudentDto'ya dönüştürür.
            var studentDto = _mapper.Map<StudentDto>(student);
            // ViewBag aracılığıyla öğrenci ID'sini view'a gönderir.
            ViewBag.StudentId = id;
            // Öğrenci bilgilerini içeren view'ı döndürür.
            return View(studentDto);
        }

        // Ödenen öğrencileri listeler.
        public async Task<IActionResult> GetPaid()
        {
            // Tüm öğrencileri asenkron olarak veritabanından çeker.
            var students = await _studentService.GetAllAsycn();
            // Öğrencileri StudentDto listesine dönüştürür.
            var studentDtos = _mapper.Map<List<StudentDto>>(students);
            // Ödenen öğrencileri içeren view'ı döndürür.
            return View(studentDtos);
        }

        // Belirli bir ödemenin raporunu görüntüler.
        public async Task<IActionResult> PaymentRapor(int id)
        {
            // ID'ye göre ödemenin, öğrenci bilgileriyle birlikte alınması.
            var values = await _paymentService.GetByIdWithStudent(id);
            // Raporu içeren view'ı döndürür.
            return View(values);
        }

        // Tüm ödemeleri listeler.
        public async Task<IActionResult> Index()
        {
            // Tüm ödemeleri, öğrenci bilgileriyle birlikte alır.
            var values = await _paymentService.GetWithStudentList();
            // Ödemeleri içeren view'ı döndürür.
            return View(values);
        }

        // Yeni bir ödeme oluşturma sayfasını döndürür.
        public async Task<IActionResult> Create()
        {
            // Ödeme oluşturma sayfasını döndürür.
            return View();
        }

        // HTTP POST isteği ile yeni bir ödeme oluşturur.
        [HttpPost]
        public async Task<IActionResult> Create(PaymentDto paymentDto)
        {
            // PaymentDto'yu Payment tipine dönüştürerek veritabanına ekler.
            var payment = await _paymentService.AddAsycn(_mapper.Map<Payment>(paymentDto));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Payment");
        }

        // Belirli bir ödemenin detaylarını görüntüler.
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            // ID'ye göre ödemeyi veritabanından alır.
            var payment = await _paymentService.GetByIdAsycn(id);
            // Ödemeyi PaymentDto'ya dönüştürür.
            var paymentDto = _mapper.Map<PaymentDto>(payment);
            // Ödeme detaylarını içeren view'ı döndürür.
            return View(paymentDto);
        }

        // Belirli bir ödemeyi siler ve ardından Index sayfasına yönlendirme yapar.
        public async Task<IActionResult> Delete(int id)
        {
            // ID'ye göre ödemeyi veritabanından alır.
            var payment = await _paymentService.GetByIdAsycn(id);
            // Ödemeyi veritabanından siler.
            await _paymentService.RemoveAsycn(_mapper.Map<Payment>(payment));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Payment");
        }
    }

}
