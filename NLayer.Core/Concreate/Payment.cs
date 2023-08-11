using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public string? PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }
        public string? Description { get; set; }

        public string? PaymentStatus { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
