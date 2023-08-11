using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.CompanyDtos
{
    public class CompanyDto : BaseDto
    {
        public string? CompanyName { get; set; }
        public string? CompanyOffical { get; set; }
        public string? CompanyTitle { get; set; }
        //yetkili bilgileri
        public int OfficalTCKN { get; set; }
        public string? OfficalName { get; set; }
        public string? OfficalSurname { get; set; }
        public string? OfficalTitle { get; set; }
        public int OfficalPhone { get; set; }
        public string? OfficalEmail { get; set; }
        public string? OfficalAdress { get; set; }
        //İletişim Bilgileri
        public int CompanyPhone { get; set; }
        public int CompanyPhone2 { get; set; }
        public string? CompanyAdress { get; set; }
        public string? CompanyAdress2 { get; set; }
        public string? CompanyCity { get; set; }
        public string? CompanyDistrict { get; set; }
        public int ZipCode { get; set; }

        public bool Condition { get; set; }
    }
}
