using BeautyHouseAM.Abstractions.Contracts;

namespace BeautyHouseAM.Abstractions.Models
{
    public abstract class BaseModel : IAuditInfo
    {
        public BaseModel()
        {
            CreatedOn = DateTime.UtcNow;
        }
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
