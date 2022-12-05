using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyHouseAM.Data.Entities
{
    public class Pedicure
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(4,2)")]
        public decimal Price { get; set; }

        public List<Pedicure> Pedicures { get; set; } = null!;
    }
}
