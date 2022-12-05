using BeautyHouseAM.Data.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using static BeautyHouseAM.Data.Constants.GlobalConstants.Rgister;

namespace BeautyHouseAM.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name ="First name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public DateTime Birthday { get; set; } 
        
        [Required]
        public Gender Gender { get; set; }

        [Required]
        [StringLength(UserNameMaxLength, MinimumLength = UserNameMinLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(EmailMaxLength)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}

