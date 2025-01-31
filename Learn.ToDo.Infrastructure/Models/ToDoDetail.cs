using Learn.ToDo.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace Learn.ToDo.Infrastructure.Models
{
    public class ToDoDetail
    {
        public int Id { get; set; }
        public UserDetail UserDetail { get; set; } = null;
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public string Title { get; set; }
        public bool IsCompleted {  get; set; }
    }
}
