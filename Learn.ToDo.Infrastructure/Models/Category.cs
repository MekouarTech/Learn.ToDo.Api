using System.ComponentModel.DataAnnotations;

namespace Learn.ToDo.Infrastructure.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public string Name { get; set; } = null;
    }
}
