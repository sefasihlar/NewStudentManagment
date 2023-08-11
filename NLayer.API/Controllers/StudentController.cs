using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Controllers.BaseController;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.StudentDtod;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    //[Authorize(AuthenticationSchemes = "Roles")]
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Student> _service;
        private readonly IStudentService _studenService;

        public StudentController(IMapper mapper, IService<Student> service, IStudentService studenService)
        {
            _mapper = mapper;
            _service = service;
            _studenService = studenService;
        }


        //Get api/students/GetWithClassList
        [HttpGet("[action]")]
        public async Task<IActionResult> GetWithClassList()
        {
            return CreateActionResult(await _studenService.GetWithClassList());
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _service.GetAllAsycn();
            var StudentDtos = _mapper.Map<List<StudentDto>>(students.ToList());
            //return Ok( CustomResponseDto<List<ClassDto>>.Success(200, classDtos));
            return CreateActionResult(CustomResponseDto<List<StudentDto>>.Success(200, StudentDtos));

        }

        //www.studentmanagment.com/api/classes/3

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Student = await _service.GetByIdAsycn(id);
            var studentDto = _mapper.Map<StudentDto>(Student);
            return CreateActionResult(CustomResponseDto<StudentDto>.Success(200, studentDto));

        }

        [HttpPost()]
        public async Task<IActionResult> Create(StudentDto studentDto)
        {
            var Student = await _service.AddAsycn(_mapper.Map<Student>(studentDto));
            var StudentsDto = _mapper.Map<StudentDto>(Student);
            return CreateActionResult(CustomResponseDto<StudentDto>.Success(201, StudentsDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(StudentDto studentDto)
        {
            await _service.UpdateAsycn(_mapper.Map<Student>(studentDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Student = await _service.GetByIdAsycn(id);

            //if (Class==null)
            //{
            //    return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404,"Bu id de bir sınıf öğesi bulunmadı"));
            //}

            await _service.RemoveAsycn(Student);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }
    }
}
