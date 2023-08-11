using FluentValidation;
using NLayer.Core.DTOs.StudentDtod;

namespace NLayer.Service.FluentValidations
{
    public class StudentDtoValidator : AbstractValidator<StudentDto>
    {
        public StudentDtoValidator()
        {
            RuleFor(a => a.Name).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(a => a.SurName).NotNull().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(a => a.Price).InclusiveBetween(1, int.MaxValue).WithMessage("Fiyat alanı 0 dan büyük olmalıdır");
            RuleFor(a => a.Adress).NotNull().WithMessage("Adress alanı boş geçilemez");
            RuleFor(a => a.GuardianName).NotNull().WithMessage("Veli adı boş geçilemez");
            RuleFor(a => a.GuardianSurName).NotNull().WithMessage("Veli soyad alanı boş geçilemez");
            RuleFor(a => a.GuardianPhone).NotNull().WithMessage("Veli telefon alanı boş geçilemez");
            RuleFor(a => a.ClassId).InclusiveBetween(1, int.MaxValue).WithMessage("Sınıf boş geçilemez");
        }
    }
}
