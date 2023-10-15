using System.ComponentModel.DataAnnotations;

namespace BSESAPI_CRUD.Entities
{
    public class ConsumerInfromation
    {
        public int Id { get; set; }
        public string? ConsumerType { get; set; }
        
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }
        
        public string? RelationName { get; set; }

        public string Sonof { get; set; }

        public string DaughterOf { get; set; }

        public string WifeOF{ get; set; }
    }
}
