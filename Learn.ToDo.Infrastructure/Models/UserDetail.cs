using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Infrastructure.Models
{
    public class UserDetail
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null;
        public List<ToDoDetail>? ToDoDetail { get; set; }
    }
}
