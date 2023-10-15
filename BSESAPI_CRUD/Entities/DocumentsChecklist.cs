using System.ComponentModel.DataAnnotations;

namespace BSESAPI_CRUD.Entities
{
    public class DocumentsChecklist:ImportantDocuments
    {
        public List<bool> checkBoxes { get; set; }

        
        public string? Email { get; set; }
    }
}
