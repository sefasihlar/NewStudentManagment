using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.NoteDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;
        private readonly IMapper _mapper;

        public NoteController(INoteService noteService, IMapper mapper)
        {
            _noteService = noteService;
            _mapper = mapper;
        }

        // Tüm notları asenkron olarak veritabanından çeker, NoteDto tipine dönüştürerek View'a döndürür.
        public async Task<IActionResult> Index()
        {
            var notes = await _noteService.GetAllAsycn();
            var noteDtos = _mapper.Map<List<NoteDto>>(notes.ToList());
            return View(noteDtos);
        }

        // Yeni bir not oluşturma sayfasını döndürür.
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // HTTP POST isteği ile not oluşturma işlemini gerçekleştirir.
        [HttpPost]
        public async Task<IActionResult> Create(NoteDto noteDto)
        {
            // Notun durumunu true olarak ayarlar.
            noteDto.Condition = true;
            // Notun oluşturulma tarihini şu anki zamana ayarlar.
            noteDto.CreatedDate = DateTime.Now;
            // NoteDto'yu Note tipine dönüştürerek veritabanına ekler.
            var note = await _noteService.AddAsycn(_mapper.Map<Note>(noteDto));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "Note");
        }

        // HTTP POST isteği ile not güncelleme işlemini gerçekleştirir.
        [HttpPost]
        public async Task<IActionResult> Update(NoteDto noteDto)
        {
            // Güncellenecek notu ID'ye göre veritabanından alır.
            var note = await _noteService.GetByIdAsycn(noteDto.Id);

            if (note != null)
            {
                // Notun Task özelliği güncelleniyorsa, Task özelliğini günceller.
                if (noteDto.Task != null)
                {
                    note.Task = noteDto.Task;
                    note.Favorite = note.Favorite;
                }
                // Notun Task özelliği güncellenmiyorsa, sadece Favorite özelliğini günceller.
                else if (noteDto.Task == null)
                {
                    note.Favorite = noteDto.Favorite;
                }

                // Güncellenen notu veritabanına kaydeder.
                await _noteService.UpdateAsycn(note);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                // Index sayfasına yönlendirme yapar.
                return RedirectToAction("Index", "Note");
            }

            return RedirectToAction("Index", "Note");
        }

        // Belirli bir notu siler ve ardından Index sayfasına yönlendirme yapar.
        public async Task<IActionResult> Delete(int id)
        {
            // Silinecek notu ID'ye göre veritabanından alır.
            var note = await _noteService.GetByIdAsycn(id);

            if (note != null)
            {
                // Notu veritabanından siler.
                await _noteService.RemoveAsycn(note);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
                // Index sayfasına yönlendirme yapar.
                return RedirectToAction("Index", "Note");
            }

            return RedirectToAction("Index", "Note");
        }
    }

}

