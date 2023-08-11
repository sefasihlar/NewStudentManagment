using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.PaymentDtos
{
    public class PaymentDto : BaseDto
    {
        public decimal Amount { get; set; }
        public string? PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }
        public string? PaymentStatus { get; set; }
        public string? Description { get; set; }

        public int StudentId { get; set; }
    }
}
