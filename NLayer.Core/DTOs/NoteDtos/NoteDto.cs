using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.NoteDtos
{
    public class NoteDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Task { get; set; }
        public bool Favorite { get; set; }
        public int? UserId { get; set; }
        public bool Condition { get; set; }

    }
}
