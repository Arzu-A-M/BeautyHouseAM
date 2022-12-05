using BeautyHouseAM.Data.Entities;

namespace BeautyHouseAM.MappingTable
{
    public class NailTechnicianImage
    {
        public Guid NailTechnicainId { get; set; }
        public NailTechnician NailTechnicain { get; set; }=null!;

        public Guid ImageId { get; set; }
        public Image Images { get; set; } = null!;


        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

    }
}
