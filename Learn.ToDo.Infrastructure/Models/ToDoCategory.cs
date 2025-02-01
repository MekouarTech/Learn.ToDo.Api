using Learn.ToDo.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Infrastructure.Models
{
    public class ToDoCategory
    {
        [Key]
        public int TodoCategoryId { get; set; }
        public int TodoId { get; set; }
        public int CategoryId { get; set; }
        
        [ForeignKey("TodoId")]
        public ToDoDetail ToDoDetail{ get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
