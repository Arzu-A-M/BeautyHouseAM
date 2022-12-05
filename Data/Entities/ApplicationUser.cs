using BeautyHouseAM.Abstractions.Contracts;
using BeautyHouseAM.Data.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static BeautyHouseAM.Data.Constants.GlobalConstants.ApplicationUser;

namespace BeautyHouseAM.Data.Entities
{
    public class ApplicationUser : IdentityUser<Guid>, IDeletableEntity
    {

        [PersonalData]
        [MaxLength(FirstNameMaxLength)]
        public string? FirstName { get; set; } = null!;

        [PersonalData]
        [MaxLength(LastNameMaxLength)]
        public string? LastName { get; set; } = null!;

        public DateTime? BirthDate { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedOn { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public Guid? NailTechnicianId { get; set; }
        public NailTechnician? NailTechnician { get; set; }

    
    }
}
