using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BeautyHouseAM.Data.Constants.GlobalConstants.NailTechnicon;
using BeautyHouseAM.Data.Entities.Enums;
using BeautyHouseAM.MappingTable;

namespace BeautyHouseAM.Data.Entities
{
    public class NailTechnician
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(FirstNameMaxLength)]

        public string FirstName { get; set; } = null!;
        
        [Required]
        [StringLength(LastNameMaxLength)]

        public string LastName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;
        
        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public Guid NailTechLevelId { get; set; }
       
        [Required]
        public NailTechLevel NailTechLevel { get; set; } = null!;

        [Required]
        public List<NailTechnicianImage> NailTechnicianImages { get; set; } = null!;
        

    }

}
