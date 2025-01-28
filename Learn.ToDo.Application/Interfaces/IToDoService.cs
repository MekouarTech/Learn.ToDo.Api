using Learn.ToDo.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Application.Interfaces
{
    public interface IToDoService
    {
        Task<ToDoDetail> GetToDo(string id);
        Task<List<ToDoDetail>> GetToDoList();
        Task AddToDo(ToDoDetail todo);
        Task DeleteToDo(string id);
    }
}
