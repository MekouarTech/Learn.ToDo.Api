using Learn.ToDo.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Application.Interfaces
{
    public interface IToDoService
    {
        Task<ToDoDetail> GetToDo(int id);
        Task<List<ToDoDetail>> GetToDoList();
        Task AddToDo(ToDoDetail todo);
        Task DeleteToDo(int id);
    }
}
