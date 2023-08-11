using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using NLayer.Core.DTOs.AccountDtos;
using NLayer.Core.DTOs.MessageDtos;
using NLayer.Core.DTOs.RoleDtos;
using NLayer.Core.DTOs.UserDtos;
using NLayer.Core.Services;
using NLayer.WebUI.Extensions;

namespace NLayer.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailSenderService _IEmailSederService;
        private readonly IMapper _mapper;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;


        public AccountController(UserManager<AppUser> userManager, IMapper mapper, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IEmailSenderService ıEmailSederService)
        {
            _userManager=userManager;
            _mapper=mapper;
            _roleManager=roleManager;
            _signInManager=signInManager;
            _IEmailSederService=ıEmailSederService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();

            var usersDtos = _mapper.Map<List<UserListDto>>(users.ToList());

            return View(usersDtos);

        }

      

        public async Task<IActionResult> GetUserRole(int id)
        {
            var user = await _userManager.FindByIdAsync(Convert.ToString(id));

            var roles = await _userManager.GetRolesAsync(user);

            var usersDtos = _mapper.Map<List<AppUserRoleDto>>(roles.ToList());

            return View(usersDtos);
        }


        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto appUserDto, IFormFile file)
        {
            AppUser user = new AppUser()
            {

                Name = appUserDto.Name,
                Surname = appUserDto.SurName,
                PhoneNumber = appUserDto.Phone,
                UserName = appUserDto.UserName,
                Email = appUserDto.Email,
                PasswordHash = appUserDto.Password,
                Title = appUserDto.Title,
                ImageUrl = file.FileName,

            };

            var result = await _userManager.CreateAsync(user, appUserDto.Password);

            if (file != null)
            {
                // Dosyayı uygun klasöre kaydeder.
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\cork-v3.8.0\\Employees-Foto", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Account");
            }

            return RedirectToAction("Index", "Account");

        }


        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {

            if (!ModelState.IsValid)
            {
                return View(loginDto);
            }

            var user = await _userManager.FindByNameAsync(loginDto.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu Email adresiyle daha önce bir hesap oluşturulmamış");
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "Hata",
                    Message = "Bu mail adresiyle daha önce bir hesap oluşturulmuş",
                    Css = "warning"
                });
                return View(loginDto);
            }

            //if (!await _userManager.IsEmailConfirmedAsync(user))
            //{
            //    TempData.Put("Message", new ResultMessageDto()
            //    {
            //        Title = "Uyarı!",
            //        Message = "Lütfen hesabınızı onaylayınız",
            //        Css = "warning"
            //    });
            //    return View(loginDto);
            //}


            var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, false, false);

            if (result.Succeeded)
            {
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "Başarılı",
                    Message = "Giriş işlemi başarılı",
                    Css = "success"
                });
                return RedirectToAction("Index", "Home");
            }

            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "Hata",
                Message = "Kullanıcı adı yada parola yanlış",
                Css = "success"
            });
            return View(loginDto);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "Oturum Kapatildi",
                Message = "Hesabiniz günvenli bir şekilde kapatıldı. ",
                Css = "warning"
            });

            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "Hesap Onayı",
                    Message = "Hesap onayi için bilgileriniz yanlış",
                    Css = "error"
                });
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    TempData.Put("Message", new ResultMessageDto()
                    {
                        Title = "Hesap Onayı",
                        Message = "Hesabiniz başarıyla onayladı",
                        Css = "success"
                    });

                    return RedirectToAction("Login", "Account");
                }

            }

            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "Hesap Onayı",
                Message = "Hesabiniz onaylanamadı",
                Css = "error"
            });
            return View();
        }


        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "Şifreyi ununttum",
                    Message = "Bilgilerniz hatali",
                    Css = "error"
                });
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);
            if (user == null)
            {
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "Şifreyi unuttum",
                    Message = "Epostat adresi ile bir Kullanici bulunamadi ",
                    Css = "error"
                });
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var callbackUrl = Url.Action("ResetPassword", "Account", new
            {

                Token = code

            });

            //send email

            await _IEmailSederService.SendEmailAsync(Email, "Parolayı yenile", $"<!DOCTYPE html>\r\n<html>\r\n\r\n<head>\r\n<title></title>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n<style type=\"text/css\">\r\n@media screen {{\r\n@font-face {{\r\nfont-family: 'Lato';\r\nfont-style: normal;\r\nfont-weight: 400;\r\nsrc: local('Lato Regular'), local('Lato-Regular'), url(https://fonts.gstatic.com/s/lato/v11/qIIYRU-oROkIk8vfvxw6QvesZW2xOQ-xsNqO47m55DA.woff) format('woff');\r\n}}\r\n\r\n@font-face {{\r\nfont-family: 'Lato';\r\n    font-style: normal;\r\n                font-weight: 700;\r\n                src: local('Lato Bold'), local('Lato-Bold'), url(https://fonts.gstatic.com/s/lato/v11/qdgUG4U09HnJwhYI-uK18wLUuEpTyoUstqEm5AMlJo4.woff) format('woff');\r\n}}\r\n\r\n@font-face {{\r\nfont-family: 'Lato';\r\nfont-style: italic;\r\nfont-weight: 400;\r\nsrc: local('Lato Italic'), local('Lato-Italic'), url(https://fonts.gstatic.com/s/lato/v11/RYyZNoeFgb0l7W3Vu1aSWOvvDin1pK8aKteLpeZ5c0A.woff) format('woff');\r\n}}\r\n\r\n@font-face {{\r\nfont-family: 'Lato';\r\nfont-style: italic;\r\nfont-weight: 700;\r\nsrc: local('Lato Bold Italic'), local('Lato-BoldItalic'), url(https://fonts.gstatic.com/s/lato/v11/HkF_qI1x_noxlxhrhMQYELO3LdcAZYWl9Si6vvxL-qU.woff) format('woff');\r\n}}\r\n}}\r\n\r\n/* CLIENT-SPECIFIC STYLES */\r\nbody,\r\ntable,\r\ntd,\r\na {{\r\n-webkit-text-size-adjust: 100%;\r\n-ms-text-size-adjust: 100%;\r\n}}\r\n\r\ntable,\r\ntd {{\r\nmso-table-lspace: 0pt;\r\nmso-table-rspace: 0pt;\r\n}}\r\n\r\nimg {{\r\n-ms-interpolation-mode: bicubic;\r\n}}\r\n\r\n/* RESET STYLES */\r\nimg {{\r\nborder: 0;\r\nheight: auto;\r\nline-height: 100%;\r\noutline: none;\r\ntext-decoration: none;\r\n}}\r\n\r\ntable {{\r\nborder-collapse: collapse !important;\r\n}}\r\n\r\nbody {{\r\nheight: 100% !important;\r\nmargin: 0 !important;\r\npadding: 0 !important;\r\nwidth: 100% !important;\r\n}}\r\n\r\n/* iOS BLUE LINKS */\r\na[x-apple-data-detectors] {{\r\ncolor: inherit !important;\r\ntext-decoration: none !important;\r\nfont-size: inherit !important;\r\nfont-family: inherit !important;\r\nfont-weight: inherit !important;\r\nline-height: inherit !important;\r\n}}\r\n\r\n/* MOBILE STYLES */\r\n@media screen and (max-width:600px) {{\r\nh1 {{\r\nfont-size: 32px !important;\r\nline-height: 32px !important;\r\n}}\r\n}}\r\n\r\n/* ANDROID CENTER FIX */\r\ndiv[style*=\"margin: 16px 0;\"] {{\r\nmargin: 0 !important;\r\n}}\r\n</style>\r\n</head>\r\n\r\n<body style=\"background-color: #f4f4f4; margin: 0 !important; padding: 0 !important;\">\r\n<!-- HIDDEN PREHEADER TEXT -->\r\n<div style=\"display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: 'Lato', Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;\">Burada olmanızdan heyecan duyuyoruz!\r\n</div>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\">\r\n<!-- LOGO -->\r\n<tr>\r\n<td bgcolor=\"#007fff\" align=\"center\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 600px;\">\r\n<tr>\r\n<td align=\"center\" valign=\"top\" style=\"padding: 40px 10px 40px 10px;\"> </td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n<tr>\r\n<td bgcolor=\"#007fff\" align=\"center\" style=\"padding: 0px 10px 0px 10px;\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 600px;\">\r\n<tr>\r\n<td bgcolor=\"#ffffff\" align=\"center\" valign=\"top\" style=\"padding: 40px 20px 20px 20px; border-radius: 4px 4px 0px 0px; color: #111111; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; letter-spacing: 4px; line-height: 48px;\">\r\n<h1 style=\"font-size: 48px; font-weight: 400; margin: 2;\">Şifreyi Sıfırla</h1> <img src=\" https://img.icons8.com/clouds/100/000000/handshake.png\" width=\"125\" height=\"120\" style=\"display: block; border: 0px;\" />\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n<tr>\r\n<td bgcolor=\"#f4f4f4\" align=\"center\" style=\"padding: 0px 10px 0px 10px;\">\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 600px;\">\r\n<tr>\r\n<td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 20px 30px 40px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;\">\r\n<p style=\"margin: 0;\">Şifreyi yenilemek için aşşağıdaki butona basınız.</p>\r\n</td>\r\n</tr>\r\n<tr>\r\n<td bgcolor=\"#ffffff\" align=\"left\">\r\n<table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n<tr>\r\n<td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 20px 30px 60px 30px;\">\r\n<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n<tr>\r\n<td align=\"center\" style=\"border-radius: 3px;\" bgcolor=\"#007fff\"><a href='https://www.mutlubaharat.com.tr{callbackUrl}' target=\"_blank\" style=\"font-size: 20px; font-family: Helvetica, Arial, sans-serif; color: #ffffff; text-decoration: none; color: #ffffff; text-decoration: none; padding: 15px 25px; border-radius: 2px; border: 1px solid #007fff; display: inline-block;\">Şifreyi Yenile</a></td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr>\r\n</table>\r\n</td>\r\n</tr> <!-- COPY -->\r\n<tr>\r\n<td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 0px 30px 0px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;\">\r\n\r\n</td>\r\n</tr> <!-- COPY -->\r\n<tr>\r\n<td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 20px 30px 20px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;\">\r\n<p style=\"margin: 0;\"><a href=\"#\" target=\"_blank\" style=\"color: #007fff;\">https://www.metaakdeniz.com</a></p>\r\n</td>\r\n</tr>\r\n<tr>\r\n<td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 0px 30px 20px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;\">\r\n                           \r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 0px 30px 40px 30px; border-radius: 0px 0px 4px 4px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;\">\r\n                            <p style=\"margin: 0;\">Meta Akdeniz,<br>META Team</p>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td bgcolor=\"#f4f4f4\" align=\"center\" style=\"padding: 30px 10px 0px 10px;\">\r\n                <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 600px;\">\r\n                    <tr>\r\n                        <td bgcolor=\"#007fff\" align=\"center\" style=\"padding: 30px 30px 30px 30px; border-radius: 4px 4px 4px 4px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;\">\r\n                            <h2 style=\"font-size: 20px; font-weight: 400; color:white; margin: 0;\">ACADEMY</h2>\r\n                            <p style=\"margin: 0;\"><a href=\"#\" target=\"_blank\" style=\"color: white;\">Yardımmı Lazım ? </a></p>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td bgcolor=\"#f4f4f4\" align=\"center\" style=\"padding: 0px 10px 0px 10px;\">\r\n                <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 600px;\">\r\n                    <tr>\r\n                        <td bgcolor=\"#f4f4f4\" align=\"left\" style=\"padding: 0px 30px 30px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 14px; font-weight: 400; line-height: 18px;\"> <br>\r\n                            <p style=\"margin: 0;\">Tüm Haklar Saklıdır . <a href=\"#\" target=\"_blank\" style=\"color: #111111; font-weight: 700;\">www.metaakdeniz.com</a>.</p>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n\r\n</html>");
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "Şifreyi Unuttum",
                Message = "Parola yenilemek için hesabiniza Email gönderildi",
                Css = "warning"
            });

            return RedirectToAction("Login", "Account");


        }


        [HttpGet]
        public IActionResult ResetPassword(string token)
        {
            if (token == null)
            {
                TempData.Put("Message", new ResultMessageDto()
                {
                    Title = "Şifreyi Yenileme",
                    Message = "Şifre yenileme işlemlerinde bir sorun var.Lütefen daha sonra tekrar deneyiniz",
                    Css = "error"
                });
                return RedirectToAction("Index", "Home");

            }

            //var model = new ResetPasswordDto { Token = token };
            TempData.Put("Message", new ResultMessageDto()
            {
                Title = "Şifreyi Yenileme",
                Message = "Şifeyi yenileyebilirsiniz",
                Css = "warning"
            });
            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> AssignRole(int id)
        //{
        //    var user = _userManager.Users.First(x => x.Id == id);

        //    var roles = _roleManager.Roles.ToList();

        //    TempData["UserId"] = user.Id;

        //    var userRoles = await _userManager.GetRolesAsync(user);

        //    var model = new List<RoleAssingDto>();

        //    foreach (var item in roles)
        //    {
        //        var x = new RoleAssingDto();
        //        x.RoleId = item.Id;
        //        x.Name = item.Name;
        //        x.Exists = userRoles.Contains(item.Name);
        //        model.Add(x);
        //    }

        //    return View(model);
        //}


        [HttpPost]
        public async Task<IActionResult> AssignRole([FromBody] RoleAssingDto model)
        {
            var userId = model.UserId;

            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);

            // Mevcut kullanıcının rollerini kaldırın
            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);

            foreach (var roleId in model.SelectedRoles)
            {
                var role = _roleManager.Roles.FirstOrDefault(r => r.Id == roleId);

                if (role != null)
                {
                    // Seçilen yeni rolleri kullanıcıya ekleyin
                    await _userManager.AddToRoleAsync(user, role.Name);
                    TempData.Put("Message", new ResultMessageDto()
                    {
                        Title = "İşlem Başarılı",
                        Message = "İşlem Başarılı",
                        Css = "success"
                    });
                }
            }

            return Json(new { success = true }); // Başarılı durumda JSON olarak başarıyı dön
        }



    }
}
