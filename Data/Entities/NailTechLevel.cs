using System.ComponentModel.DataAnnotations;
using BeautyHouseAM.Data.Entities.Enums;

namespace BeautyHouseAM.Data.Entities
{
    public class NailTechLevel
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Level Level { get; set; }
        
        [Required]
        public List<NailTechnician> NailTechnicons { get; set; }


    }
}
