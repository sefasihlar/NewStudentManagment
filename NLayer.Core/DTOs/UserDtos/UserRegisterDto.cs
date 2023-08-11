
using System.ComponentModel.DataAnnotations;


namespace NLayer.Core.DTOs.UserDtos
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "İsim alanı zorunludur.")]
        [RegularExpression(@"^[A-Za-zÇçĞğİıÖöŞşÜü\s]+$", ErrorMessage = "Geçerli bir isim giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadı alanı zorunludur.")]
        [RegularExpression(@"^[A-Za-zÇçĞğİıÖöŞşÜü\s]+$", ErrorMessage = "Geçerli bir soyadı giriniz.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Geçerli bir kullanıcı adı giriniz. Büyük-küçük harf veya Türkçe karakter içermemelidir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Parola alanı zorunludur.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Parola en az 6 karakter uzunluğunda olmalıdır.")]
        [RegularExpression(@"^(?=.*[a-zA-ZÇçĞğİıÖöŞşÜü])(?=.*\d).+$", ErrorMessage = "Parola en az bir büyük harf ve bir sayısal değer içermelidir.")]
        public string Password { get; set; }

        [RegularExpression(@"^(?=.*[a-zA-ZÇçĞğİıÖöŞşÜü])(?=.*\d).+$", ErrorMessage = "Tekrar Parola en az bir büyük harf ve bir sayısal değer içermelidir.")]
        [Compare("Password", ErrorMessage = "Parolalar eşleşmiyor.")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "E-posta adresi alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        public string? Phone { get; set; }

        public string Surname { get; set; }
        public string? Title { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
