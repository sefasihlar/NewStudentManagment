using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.CompanyDtos;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        // Tüm şirketleri asenkron olarak veritabanından çeker, CompanyDto tipine dönüştürerek View'a döndürür.
        public async Task<IActionResult> Index()
        {
            // Tüm şirketleri asenkron olarak veritabanından çeker.
            var values = await _companyService.GetAllAsycn();
            // Şirketleri CompanyDto listesine dönüştürür.
            var companyDto = _mapper.Map<List<CompanyDto>>(values);
            // CompanyDto listesini Index view'ına döndürür.
            return View(companyDto);
        }

        // Yeni bir şirket oluşturma sayfasını döndürür.
        [HttpGet]
        public IActionResult Create()
        {
            // Şirket oluşturma sayfasını döndürür.
            return View();
        }

        // HTTP POST isteği ile şirket oluşturma işlemini gerçekleştirir.
        [HttpPost]
        public async Task<IActionResult> Create(CompanyDto companyDto)
        {
      

       
            // Oluşturulan şirketin oluşturma tarihini şu anki zamana ayarlar.
            companyDto.CreatedDate = DateTime.Now;
            // Şirketin durumunu true olarak ayarlar.
            companyDto.Condition = true;
            // CompanyDto'yu Company tipine dönüştürerek veritabanına ekler.
            var company = await _companyService.AddAsycn(_mapper.Map<Company>(companyDto));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            var companyDtoResult = _mapper.Map<CompanyDto>(company);
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Company");
        }

        // HTTP POST isteği ile şirket güncelleme işlemini gerçekleştirir.
        [HttpPost]
        public async Task<IActionResult> Update(CompanyDto companyDto)
        {
            // Güncellenecek şirketi ID'ye göre veritabanından alır.
            var company = await _companyService.GetByIdAsycn(companyDto.Id);
            // Şirket null değilse:
            if (company != null)
            {
                // Şirketin özelliklerini günceller.
                company.CompanyName = companyDto.CompanyName;
                company.CompanyOffical = companyDto.CompanyOffical;
                company.CompanyTitle = companyDto.CompanyTitle;
                company.OfficalTCKN = companyDto.OfficalTCKN;
                company.OfficalName = companyDto.OfficalName;
                company.OfficalSurname = companyDto.OfficalSurname;
                company.OfficalTitle = companyDto.OfficalTitle;
                company.OfficalPhone = companyDto.OfficalPhone;
                company.OfficalEmail = companyDto.OfficalEmail;
                company.OfficalAdress = companyDto.OfficalAdress;
                company.CompanyPhone = companyDto.CompanyPhone;
                company.CompanyPhone2 = companyDto.CompanyPhone2;
                company.CompanyAdress = companyDto.CompanyAdress;
                company.CompanyAdress2 = companyDto.CompanyAdress2;
                company.CompanyAdress = company.CompanyAdress2;
                company.CompanyAdress  =companyDto.CompanyAdress2;

                // Güncellenen şirketi veritabanına kaydeder.
                await _companyService.UpdateAsycn(company);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                // Index sayfasına yönlendirme yapar.
                return RedirectToAction("Index", "Company");
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Company");
        }

        // Belirli bir şirketi siler ve ardından Index sayfasına yönlendirme yapar.
        public async Task<IActionResult> Delete(int id)
        {
            // ID'ye göre şirketi veritabanından alır.
            var company = await _companyService.GetByIdAsycn(id);
            // Şirket null değilse:
            if (company != null)
            {
                // Şirketi veritabanından siler.
                await _companyService.RemoveAsycn(company);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                // Index sayfasına yönlendirme yapar.
                return RedirectToAction("Index", "Company");
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Company");
        }

        // Belirli bir şirketi ID'ye göre veritabanından alır ve JSON formatında geri döner.
        [HttpGet]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            // Tüm şirketleri asenkron olarak veritabanından çeker.
            var companies = await _companyService.GetAllAsycn();
            // ID'ye göre şirketi bulur.
            var findCompany = companies.FirstOrDefault(x => x.Id == id);
            // Şirketi JSON formatına dönüştürür.
            var jsonCompany = JsonConvert.SerializeObject(findCompany);
            // JSON formatındaki şirketi döner.
            return Json(jsonCompany);
        }
    }

}
