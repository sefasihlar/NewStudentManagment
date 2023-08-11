using NLayer.Core.Concreate;

namespace NLayer.Core.DTOs.UserDtos
{
    public class AppUserDto : AppUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public String? SurName { get; set; }
        public string? UserName { get; set; }
        public string Surname { get; set; }
        //public string? Title { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PasswordHash { get; set; }
        public bool? Condition { get; set; }

    }
}
