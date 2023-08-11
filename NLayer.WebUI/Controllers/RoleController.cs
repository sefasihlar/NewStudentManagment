using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.RoleDtos;
using NLayer.Core.DTOs.UserDtos;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IMapper _mapper;

        public RoleController(RoleManager<AppRole> roleManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _mapper=mapper;
            _userManager=userManager;
        }

        public IActionResult Index()
        {
            var values = new AppRoleListDto()
            {
                Roles = _roleManager.Roles.ToList(),
            };

            return View(values);
        }

        [HttpGet]
        public async Task<ActionResult> GetRoleList(int id)
        {
            var user = _userManager.Users.First(x => x.Id == id);

            var roles = _roleManager.Roles.ToList();

            TempData["UserId"] = user.Id;

            var userRoles = await _userManager.GetRolesAsync(user);

            var model = new List<RoleAssingDto>();

            foreach (var item in roles)
            {
                var x = new RoleAssingDto();
                x.RoleId = item.Id;
                x.Name = item.Name;
                x.Exists = userRoles.Contains(item.Name);
                model.Add(x);
            }

            // Direkt modeli JSON formatında döndür
            return Json(model);
        }

        public async Task<IActionResult> Users()
        {
            var users = await _userManager.Users.ToListAsync();

            var usersDtos = _mapper.Map<List<UserListDto>>(users.ToList());

            return View(usersDtos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(AppRoleDto appRoleDto)
        {

            var values = new AppRole()
            {
                Name = appRoleDto.Name,
                CreatedDate = appRoleDto.CreatedDate,
                UpdatedDate = appRoleDto.UpdatedDate,
                Condition = appRoleDto.Condition,
            };

            var result = await _roleManager.CreateAsync(values);

            if (result.Succeeded)
            {
                TempData.Put("message", new ResultMessageDto()
                {
                    Title = "Başarılı",
                    Message = "Role başarıyla eklendi",
                    Css = "success"
                });
                return RedirectToAction("Index", "Role");

            }

            return View(appRoleDto);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            if (values == null)
            {
                return NotFound();
            }

            var model = new AppRoleDto()
            {
                Id = values.Id,
                Name = values.Name,
            };

            return View(model);
        }
        [HttpPost]

        public async Task<IActionResult> Update(AppRoleDto model)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == model.Id);

            if (values != null)
            {
                values.Name = model.Name;
                var result = await _roleManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }

                else
                {
                    TempData.Put("message", new ResultMessageDto()
                    {
                        Title = "Hata",
                        Message = "Role güncelleme işlemi başarısız.Lütfen bigileri gözden geçiriniz",
                        Css = "error"
                    });
                }
            }

            return View(model);

        }

        public async Task<IActionResult> Delete(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            if (values != null)
            {
                var result = await _roleManager.DeleteAsync(values);
                if (result.Succeeded)
                {
                    TempData.Put("message", new ResultMessageDto()
                    {
                        Title = "Başarılı",
                        Message = "Role silme işlemi başarılı",
                        Css = "success"
                    });
                    return RedirectToAction("Index", "Role");
                }
            }
            TempData.Put("message", new ResultMessageDto()
            {
                Title = "Hata",
                Message = "Role silme işlemi başarısız.Lütefen daha sonra tekarar deneyiniz",
                Css = "error"
            });
            return View();

        }

    }
}
