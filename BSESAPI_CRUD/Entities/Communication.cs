using System.ComponentModel.DataAnnotations;

namespace BSESAPI_CRUD.Entities
{
    public class Communication
    {
        [MaxLength(255)]
        [Required]
        public string HouseNo { get; set; }

        public int Floor { get; set; }

        [MaxLength(255)]
        [Required]
        public string? BuildingName { get; set; }

        [MaxLength(255)]
        [Required]
        public string? Street { get; set; }

        [MaxLength(255)]
        [Required]
        public string? Colony { get; set; }

        public string landmark { get; set; }

        public string landmarkDetails { get; set; }

        [Required]
        public int? CityPostalCode { get; set; }

        [MaxLength(255)]
        [Required]
        public string? Locality { get; set; }

        public string? Division { get; set; }

        [MaxLength(255)]
        public string Indicatelandmark { get; set; }

    }
}
