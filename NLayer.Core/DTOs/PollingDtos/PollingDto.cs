using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.PollingDtos
{
    public class PollingDto : BaseDto
    {
        public string? Name { get; set; }
        public DateTime? PollingDate { get; set; }

        public string? Description { get; set; }

        public int ClassId { get; set; }
    }
}
