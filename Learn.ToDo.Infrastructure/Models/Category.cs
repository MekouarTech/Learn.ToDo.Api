using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Infrastructure.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
