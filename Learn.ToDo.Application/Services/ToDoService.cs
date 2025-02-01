using Learn.ToDo.Application.Interfaces;
using Learn.ToDo.Infrastructure.Data;
using Learn.ToDo.Infrastructure.Models;
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
        private readonly TodoContext _todoContext;

        public ToDoService(IMemoryCache memoryCache, TodoContext todoContext)
        {
            _memoryCache = memoryCache;
            this._todoContext = todoContext;
        }

        public async Task AddToDo(ToDoDetail todo)
        {
            _todoContext.ToDoDetails.Add(todo);
            _todoContext.SaveChanges();
        }

        public async Task DeleteToDo(int id)
        {
            var todo = await GetToDo(id);
            _todoContext.ToDoDetails.Remove(todo);
            _todoContext.SaveChanges();
        }

        public async Task<ToDoDetail> GetToDo(int id) => _todoContext.ToDoDetails.FirstOrDefault(x => x.TodoId == id);


        public async Task<List<ToDoDetail>> GetToDoList() => _todoContext.ToDoDetails.Where(x => x.UserId == 1).ToList();
    }
}
