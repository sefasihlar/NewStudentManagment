using NLayer.Core.Concreate;
using NLayer.Core.DTOs.PaymentDtos;

namespace NLayer.Core.Services
{
    public interface IPaymentService : IService<Payment>
    {
        Task<List<GetWithStudentListDto>> GetWithStudentList();

        Task<GetByIdWithStudentDto> GetByIdWithStudent(int id);

    }
}
