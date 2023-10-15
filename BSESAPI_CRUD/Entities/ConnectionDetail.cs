using System.ComponentModel.DataAnnotations;

namespace BSESAPI_CRUD.Entities
{
    public class ConnectionDetail
    {
        public bool isPermanent { get; set; }
        public bool isTemporary { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        public int Load { get; set; }

        [MaxLength(255)]
        public string? Purpose { get; set; }

        [Required]
        public string? AreaType { get; set; }

        [Required]
        public string? MyPremises { get; set; }

        [Required]
        public  string? BuildingType { get; set; }

        public bool isYes { get; set; }
    }
}
