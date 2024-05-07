using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{

    
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<BookTag>? Tags { get; set; }
    }
}
