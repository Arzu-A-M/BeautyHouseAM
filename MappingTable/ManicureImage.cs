using BeautyHouseAM.Abstractions.Contracts;
using BeautyHouseAM.Data.Entities;

namespace BeautyHouseAM.MappingTable
{
    public class ManicureImage: IDeletableEntity
    {
        public Guid ManicureId { get; set; }
        public Manicure Manicure { get; set; } = null!;


        public Guid ImageId { get; set; }
        public Image Image { get; set; } = null!;


        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
