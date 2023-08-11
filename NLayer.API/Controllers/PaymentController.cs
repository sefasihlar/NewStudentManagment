using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Controllers.BaseController;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.PaymentDtos;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{

    //[Authorize(AuthenticationSchemes = "Roles")]
    //[Authorize(Roles ="Admin")]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPaymentService _service;

        public PaymentController(IMapper mapper, IPaymentService service)
        {
            _mapper = mapper;
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var payments = await _service.GetAllAsycn();
            var StudentDtos = _mapper.Map<List<PaymentDto>>(payments.ToList());
            //return Ok( CustomResponseDto<List<ClassDto>>.Success(200, classDtos));
            return CreateActionResult(CustomResponseDto<List<PaymentDto>>.Success(200, StudentDtos));

        }


        //[HttpGet("[action]")]
        //public async Task<IActionResult> GetWithStudentList()
        //{
        //    return CreateActionResult(await _service.GetWithStudentList());
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Payment = await _service.GetByIdAsycn(id);
            var paymentDto = _mapper.Map<PaymentDto>(Payment);
            return CreateActionResult(CustomResponseDto<PaymentDto>.Success(200, paymentDto));

        }

        [HttpPost()]
        public async Task<IActionResult> Create(PaymentDto paymentDto)
        {
            var Payment = await _service.AddAsycn(_mapper.Map<Payment>(paymentDto));
            var paymentsDto = _mapper.Map<PaymentDto>(Payment);
            return CreateActionResult(CustomResponseDto<PaymentDto>.Success(201, paymentsDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(PaymentDto paymentDto)
        {
            await _service.UpdateAsycn(_mapper.Map<Payment>(paymentDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Payment = await _service.GetByIdAsycn(id);

            //if (Class==null)
            //{
            //    return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404,"Bu id de bir sınıf öğesi bulunmadı"));
            //}
            await _service.RemoveAsycn(Payment);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
