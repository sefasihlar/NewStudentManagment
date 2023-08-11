using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Controllers.BaseController;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.ClassDtos;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{

    //[Authorize(AuthenticationSchemes = "Roles")]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : CustomBaseController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IClassService _service;

        public ClassController(IMapper mapper, IService<Class> service, IClassService classService, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _service = classService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var classes = await _service.GetAllAsycn();
            var classDtos = _mapper.Map<List<ClassDto>>(classes.ToList());
            //return Ok( CustomResponseDto<List<ClassDto>>.Success(200, classDtos));
            var userId = _userManager.GetUserName((System.Security.Claims.ClaimsPrincipal)User);
            return CreateActionResult(CustomResponseDto<List<ClassDto>>.Success(200, classDtos));

        }

        //www.studentmanagment.com/api/classes/3

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Class = await _service.GetByIdAsycn(id);
            var classDto = _mapper.Map<ClassDto>(Class);
            return CreateActionResult(CustomResponseDto<ClassDto>.Success(200, classDto));

        }


        [HttpGet("[action]/{classId}")]
        public async Task<IActionResult> GetByClassIdWithStudent(int classId)
        {
            return CreateActionResult(await _service.GetByClassIdWithStudentAsycn(classId));
        }

        [HttpPost()]
        public async Task<IActionResult> Create(ClassDto classDto)
        {
            var Class = await _service.AddAsycn(_mapper.Map<Class>(classDto));
            var classesDto = _mapper.Map<ClassDto>(Class);
            return CreateActionResult(CustomResponseDto<ClassDto>.Success(201, classesDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(ClassDto classDto)
        {
            await _service.UpdateAsycn(_mapper.Map<Class>(classDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Class = await _service.GetByIdAsycn(id);

            //if (Class==null)
            //{
            //    return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404,"Bu id de bir sınıf öğesi bulunmadı"));
            //}

            await _service.RemoveAsycn(Class);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
