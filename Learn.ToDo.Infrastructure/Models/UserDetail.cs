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
        public int Id { get; set; }
        public string Username { get; set; } = null;
    }
}
