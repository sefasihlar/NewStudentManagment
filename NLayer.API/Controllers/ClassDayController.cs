using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Controllers.BaseController;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.CLassDayDtos;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{

    //[Authorize(AuthenticationSchemes = "Roles")]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClassDayController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IClassDayService _service;

        public ClassDayController(IMapper mapper, IService<ClassDay> service, IClassDayService classService)
        {
            _mapper = mapper;
            _service = classService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var classDays = await _service.GetAllAsycn();
            var classDayDtos = _mapper.Map<List<ClassDayDto>>(classDays.ToList());
            //return Ok( CustomResponseDto<List<ClassDayDto>>.Success(200, classDtos));
            return CreateActionResult(CustomResponseDto<List<ClassDayDto>>.Success(200, classDayDtos));

        }

        //www.studentmanagment.com/api/classes/3

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ClassDay = await _service.GetByIdAsycn(id);
            var classDayDto = _mapper.Map<ClassDayDto>(ClassDay);
            return CreateActionResult(CustomResponseDto<ClassDayDto>.Success(200, classDayDto));

        }

        [HttpPost()]
        public async Task<IActionResult> Create(ClassDayDto classDayDto)
        {
            var ClassDay = await _service.AddAsycn(_mapper.Map<ClassDay>(classDayDto));
            var classesDto = _mapper.Map<ClassDayDto>(ClassDay);
            return CreateActionResult(CustomResponseDto<ClassDayDto>.Success(201, classesDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(ClassDayDto classDayDto)
        {
            await _service.UpdateAsycn(_mapper.Map<ClassDay>(classDayDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

        [HttpDelete("{classId}/{dayId}")]
        public async Task<IActionResult> Delete(int classId, int dayId)
        {
            //if (ClassDay == null)
            //{
            //    return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "Bu id de bir sınıf öğesi bulunmadı"));
            //}

            await _service.RemoveClassDaysAsync(classId, dayId);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

    }
}
