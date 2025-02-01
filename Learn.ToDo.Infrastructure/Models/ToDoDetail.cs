using Learn.ToDo.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learn.ToDo.Infrastructure.Models
{
    public class ToDoDetail
    {
        [Key]
        public int TodoId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserDetail UserDetail { get; set; } = null;
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public string Title { get; set; }
        public bool IsCompleted {  get; set; }
    }
}
