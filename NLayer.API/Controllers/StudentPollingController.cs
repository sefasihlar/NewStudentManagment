using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Controllers.BaseController;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.StudentPollingDtos;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    //[Authorize(AuthenticationSchemes = "Roles")]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPollingController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IStudentPollingService _service;

        public StudentPollingController(IMapper mapper, IService<StudentPolling> service, IStudentPollingService classService)
        {
            _mapper = mapper;
            _service = classService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var classes = await _service.GetAllAsycn();
            var classDtos = _mapper.Map<List<StudentPollingDto>>(classes.ToList());
            //return Ok( CustomResponseDto<List<StudentPollingDto>>.Success(200, studentPollingDtos));
            return CreateActionResult(CustomResponseDto<List<StudentPollingDto>>.Success(200, classDtos));

        }

        //www.studentmanagment.com/api/classes/3

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var StudentPolling = await _service.GetByIdAsycn(id);
            var classDto = _mapper.Map<StudentPollingDto>(StudentPolling);
            return CreateActionResult(CustomResponseDto<StudentPollingDto>.Success(200, classDto));

        }

        [HttpPost()]
        public async Task<IActionResult> Create(StudentPollingDto studentPollingDto)
        {
            var StudentPolling = await _service.AddAsycn(_mapper.Map<StudentPolling>(studentPollingDto));
            var studentPollingsDto = _mapper.Map<StudentPollingDto>(StudentPolling);
            return CreateActionResult(CustomResponseDto<StudentPollingDto>.Success(201, studentPollingsDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(StudentPollingDto studentPollingDto)
        {
            await _service.UpdateAsycn(_mapper.Map<StudentPolling>(studentPollingDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

        [HttpDelete("{PollingId}/{StudentId}")]
        public async Task<IActionResult> Delete(int PollingId, int StudentId)
        {

            //if (StudentPolling==null)
            //{
            //    return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404,"Bu id de bir sınıf öğesi bulunmadı"));
            //}

            await _service.RemoveStudentPollingAsync(PollingId, StudentId);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
