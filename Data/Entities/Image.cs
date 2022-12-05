using BeautyHouseAM.MappingTable;
using System.ComponentModel.DataAnnotations;

namespace BeautyHouseAM.Data.Entities
{
    public class Image 
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        public List<ApplicationUser> UsersImages { get; set; } = new List<ApplicationUser>();

        public List<PedicureImage> PedicureImages { get; set; } = new List<PedicureImage>();

        public List<NailTechnicianImage> NailTechnicianImages { get; set; } = new List<NailTechnicianImage>();

        public List<ManicureImage> ManucureImages { get; set; } = new List<ManicureImage>();
    }
}
