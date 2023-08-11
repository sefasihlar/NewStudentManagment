using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concreate;

namespace NLayer.Repository.Seeds
{
    public class StudentSeed : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student { Id = 1, Name = "Ahmet", Price = 500, SurName = "Çakır", GuardianName = "Hatice", GuardianSurName = "Çakır", GuardianPhone = "05525326858", Condition = true, Gender = false, Adress = "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:29 NO:4", ClassId = 1, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Student { Id = 2, Name = "Mehmet", Price = 500, SurName = "Topal", GuardianName = "Ahmet", GuardianSurName = "Topal", GuardianPhone = "05525326858", Condition = true, Gender = true, Adress = "Antalya/Kepze Kültür Mah. Galipkaya cad. BinaNo:12 NO:1", ClassId = 2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Student { Id = 3, Name = "Veli", Price = 500, SurName = "Bozkır", GuardianName = "Hatice", GuardianSurName = "Bozkır", GuardianPhone = "05525326858", Condition = true, Gender = true, Adress = "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:76 NO:3", ClassId = 1, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Student { Id = 4, Name = "Oğuzhan", Price = 500, SurName = "Kılınç", GuardianName = "Hatice", GuardianSurName = "Kılınç", GuardianPhone = "05525326858", Condition = true, Gender = true, Adress = "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:5 NO:42", ClassId = 3, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Student { Id = 5, Name = "Metehan", Price = 500, SurName = "Bozkurt", GuardianName = "Hatice", GuardianSurName = "Bozkurt", GuardianPhone = "05525326858", Condition = true, Gender = true, Adress = "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:2 NO:43", ClassId = 1, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Student { Id = 6, Name = "İbrahim", Price = 500, SurName = "Eroğlu", GuardianName = "Yeliz", GuardianSurName = "Eroğlu", GuardianPhone = "05525326858", Condition = true, Gender = true, Adress = "Antalya/Kepez Kültür Mah. Galipkaya cad. BinaNo:59 NO:44", ClassId = 2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
                );
        }
    }
}
