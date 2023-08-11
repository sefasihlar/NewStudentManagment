using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.TodoListDtos
{
    public class TodoListDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? Task { get; set; }
        public bool Favorite { get; set; }
        public int? UserId { get; set; }
        public bool Condition { get; set; }
    }
}
