using AutoMapper;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.PaymentDtos;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class PaymentService : Service<Payment>, IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;
        public PaymentService(GenericRepository<Payment> repository, IUnitOfWork unitOfWork, IPaymentRepository paymentRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdWithStudentDto> GetByIdWithStudent(int id)
        {
            var payment = await _paymentRepository.GetByIdWithStudent(id);
            var paymentDto = _mapper.Map<GetByIdWithStudentDto>(payment);
            return paymentDto;
        }



        public async Task<List<GetWithStudentListDto>> GetWithStudentList()
        {
            var payment = await _paymentRepository.GetWithStudentList();
            var paymentDto = _mapper.Map<List<GetWithStudentListDto>>(payment);
            return paymentDto.ToList();
        }
    }
}
