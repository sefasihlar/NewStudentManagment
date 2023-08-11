using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Controllers.BaseController;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.PollingDtos;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{

    //[Authorize(AuthenticationSchemes = "Roles")]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PollingController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPollingService _service;

        public PollingController(IMapper mapper, IPollingService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pollings = await _service.GetAllAsycn();
            var pollingDtos = _mapper.Map<List<PollingDto>>(pollings.ToList());
            //return Ok( CustomResponseDto<List<ClassDto>>.Success(200, classDtos));
            return CreateActionResult(CustomResponseDto<List<PollingDto>>.Success(200, pollingDtos));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Polling = await _service.GetByIdAsycn(id);
            var pollingDto = _mapper.Map<PollingDto>(Polling);
            return CreateActionResult(CustomResponseDto<PollingDto>.Success(200, pollingDto));

        }

        [HttpPost()]
        public async Task<IActionResult> Create(PollingDto pollingDto)
        {
            var Polling = await _service.AddAsycn(_mapper.Map<Polling>(pollingDto));
            var pollingsDto = _mapper.Map<PollingDto>(Polling);
            return CreateActionResult(CustomResponseDto<PollingDto>.Success(201, pollingsDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(PollingDto pollingDto)
        {
            await _service.UpdateAsycn(_mapper.Map<Polling>(pollingDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Polling = await _service.GetByIdAsycn(id);

            //if (Class==null)
            //{
            //    return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404,"Bu id de bir sınıf öğesi bulunmadı"));
            //}
            await _service.RemoveAsycn(Polling);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
