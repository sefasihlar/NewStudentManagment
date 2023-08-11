using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.TodoListDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class TodoListController : Controller
    {
        private readonly ITodoListService _todoListService;
        private readonly IMapper _mapper;

        public TodoListController(ITodoListService todoListService, IMapper mapper)
        {
            _todoListService = todoListService;
            _mapper = mapper;
        }

        // Tüm yapılacakları listeleri alır, TodoListDto'ya dönüştürür ve Index view'ına döndürür.
        public async Task<IActionResult> Index()
        {
            // Tüm yapılacakları listeleri alır.
            var todoLists = await _todoListService.GetAllAsycn();
            // TodoListDto'ya dönüştürür.
            var todoListDto = _mapper.Map<List<TodoListDto>>(todoLists).ToList();
            // Index view'ına yapılacakları listeleri döndürür.
            return View(todoListDto.ToList());
        }

        // Yeni bir yapılacak listesi oluşturmak için Create view'ını döndürür.
        public async Task<IActionResult> Create()
        {
            // Create view'ını döndürür.
            return View();
        }

        // HTTP POST isteği ile yeni bir yapılacak listesi oluşturur.
        [HttpPost]
        public async Task<IActionResult> Create(TodoListDto todoDto)
        {
            // Yapılacak listesinin özelliklerini ayarlar.
            todoDto.Task = false;
            todoDto.Condition = true;
            todoDto.CreatedDate = DateTime.Now;
            // Yapılacak listesini veritabanına ekler.
            var values = await _todoListService.AddAsycn(_mapper.Map<TodoList>(todoDto));
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "",
                Message = "İşlem Başarılı",
                Css = "success"
            });
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "TodoList");
        }

        // Belirli bir yapılacak listesini siler ve ardından Index sayfasına yönlendirme yapar.
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            // ID'ye göre yapılacak listesini veritabanından alır.
            var task = await _todoListService.GetByIdAsycn(id);
            // Yapılacak liste varsa veritabanından siler.
            if (task != null)
            {
                await _todoListService.RemoveAsycn(task);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
            }
            await _todoListService.RemoveAsycn(task);
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "TodoList");
        }

        // Belirli bir yapılacak listesinin görev durumunu günceller ve ardından Index sayfasına yönlendirme yapar.
        [HttpPost]
        public async Task<IActionResult> UpdateTask(TodoListDto todoListDto)
        {
            // ID'ye göre yapılacak listesini veritabanından alır.
            var todo = await _todoListService.GetByIdAsycn(todoListDto.Id);
            // Yapılacak liste varsa görev durumunu günceller.
            if (todo != null)
            {
                todo.Task = todoListDto.Task;
                todo.Favorite = false;
                await _todoListService.UpdateAsycn(todo);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "TodoList");
        }

        // Belirli bir yapılacak listesinin favori durumunu günceller ve ardından Index sayfasına yönlendirme yapar.
        [HttpPost]
        public async Task<IActionResult> UpdateFavorite(TodoListDto todoListDto)
        {
            // ID'ye göre yapılacak listesini veritabanından alır.
            var todo = await _todoListService.GetByIdAsycn(todoListDto.Id);
            // Yapılacak liste varsa favori durumunu günceller.
            if (todo != null)
            {
                todo.Favorite = todoListDto.Favorite;
                await _todoListService.UpdateAsycn(todo);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "TodoList");
        }

        // Belirli bir yapılacak listesinin verilerini günceller ve ardından Index sayfasına yönlendirme yapar.
        [HttpPost]
        public async Task<IActionResult> UpdateData(TodoListDto todoListDto)
        {
            // ID'ye göre yapılacak listesini veritabanından alır.
            var todo = await _todoListService.GetByIdAsycn(todoListDto.Id);
            // Yapılacak liste varsa verilerini günceller.
            if (todo != null)
            {
                todo.Title = todoListDto.Title;
                todo.Description = todoListDto.Description;
                todo.UpdatedDate = DateTime.Now;
                await _todoListService.UpdateAsycn(todo);
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "",
                    Message = "İşlem Başarılı",
                    Css = "success"
                });
            }
            // Index sayfasına yönlendirme yapar.
            return RedirectToAction("Index", "TodoList");
        }

        // Belirli bir yapılacak listesinin detaylarını ID'ye göre alır ve JSON formatında döndürür.
        public async Task<IActionResult> Detail(int id)
        {
            // ID'ye göre yapılacak listesini veritabanından alır.
            var todo = await _todoListService.GetByIdAsycn(id);
            // JSON formatına dönüştürür.
            var jsonTodo = JsonConvert.SerializeObject(todo);
            // JSON formatındaki yapılacak listeyi döndürür.
            return Json(jsonTodo);
        }
    }


}
