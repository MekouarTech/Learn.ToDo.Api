using Learn.ToDo.Application.Interfaces;
using Learn.ToDo.Application.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Learn.ToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            this._toDoService = toDoService;
        }

        [HttpGet]
        public async Task<List<ToDoDetail>> GetAllTodos()
        {
            List<ToDoDetail> toDoDetails = await _toDoService.GetToDoList();
            return toDoDetails;
        }

        [HttpGet("{id}")]
        public async Task<ToDoDetail> GetToDoByID(string id)
        {
            return await _toDoService.GetToDo(id);
        }

        [HttpPost(Name = "PostToDo")]
        public async Task PostToDo(ToDoDetail todo)
        {
            await _toDoService.AddToDo(todo);
        }

        [HttpDelete(Name = "DeleteToDo")]
        public async Task DeleteToDo(string todo)
        {
            await _toDoService.DeleteToDo(todo);
        }
    }
}
