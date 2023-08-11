using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs.NoteDtos;
using NLayer.Core.Services;

namespace NLayer.WebUI.ViewComponents
{
    public class GetNoteList : ViewComponent
    {

        private readonly INoteService _noteService;
        private readonly IMapper _mapper;

        public GetNoteList(INoteService noteService, IMapper mapper)
        {
            _noteService=noteService;
            _mapper=mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notes = await _noteService.GetAllAsycn();
            var lastThreeItems = notes.TakeLast(5).ToList();
            var noteDtos = _mapper.Map<List<NoteDto>>(lastThreeItems.ToList());
            return View(noteDtos);
        }
    }
}
