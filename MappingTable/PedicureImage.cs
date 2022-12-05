using BeautyHouseAM.Abstractions.Contracts;
using BeautyHouseAM.Data.Entities;

namespace BeautyHouseAM.MappingTable
{
    public class PedicureImage : IDeletableEntity
    {
        public Guid PedicureId { get; set; }
        public Pedicure Pedicure { get; set; } = null!;

        public Guid ImageId { get; set; }
        public Image Image { get; set; } = null!;

        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
