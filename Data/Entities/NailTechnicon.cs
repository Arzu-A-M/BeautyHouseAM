using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BeautyHouseAM.Data.Constants.GlobalConstants.NailTechnicon;
using BeautyHouseAM.Data.Entities.Enums;

namespace BeautyHouseAM.Data.Entities
{
    public class NailTechnicon
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(FirstNameMaxLength)]

        public string FirstName { get; set; } = null!;
        
        [Required]
        [StringLength(LastNameMaxLength)]

        public string LastName { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;
        
        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;


        [Required]
        [Column(TypeName = "decimal(4,2)")]
        public decimal Rating { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int NailTechLevelId { get; set; }
       
        [Required]
        public NailTechLevel NailTechLevel { get; set; } = null!;

        [Required]
        public List<Manicure> Manicures { get; set; }
        
        [Required]
        public List<Pedicure> Pedicures { get; set; }







    }

}
