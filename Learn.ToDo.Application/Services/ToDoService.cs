using Learn.ToDo.Application.Interfaces;
using Learn.ToDo.Application.Model;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Application.Services
{
    public class ToDoService : IToDoService
    {
        private IMemoryCache _memoryCache;
        public ToDoService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;   
        }

        public async Task AddToDo(ToDoDetail todo) => _memoryCache.Set(todo.Id, todo);
        
        public async Task DeleteToDo(string id) => _memoryCache.Remove(id);

        public async Task<ToDoDetail> GetToDo(string id) => _memoryCache.TryGetValue(id, out ToDoDetail todo) ? todo : null;


        public async Task<List<ToDoDetail>> GetToDoList()
        {
            List<ToDoDetail> list = new List<ToDoDetail>();

            ToDoDetail todo1 = await this.GetToDo("1");
            ToDoDetail todo2 = await this.GetToDo("2");
            ToDoDetail todo3 = await this.GetToDo("3");
            
            list.Add(todo1);
            list.Add(todo2);
            list.Add(todo3);

            return list;
        }
    }
}
