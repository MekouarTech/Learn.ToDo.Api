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
        public int Id { get; set; }
        public ToDoDetail ToDoDetail{ get; set; }
        public Category Category { get; set; }
    }
}
