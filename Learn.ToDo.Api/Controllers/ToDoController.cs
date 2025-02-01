// <copyright file="ToDoController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Learn.ToDo.Api.Controllers
{
    using Learn.ToDo.Api.RequestsModel;
    using Learn.ToDo.Application.Interfaces;
    using Learn.ToDo.Infrastructure.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService toDoService;

        public ToDoController(IToDoService toDoService) =>
            this.toDoService = toDoService;

        [HttpGet]
        public async Task<List<ToDoDetail>> GetAllTodos()
        {
            List<ToDoDetail> toDoDetails = await this.toDoService.GetToDoList();
            return toDoDetails;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet("{id}")]
        public async Task<ToDoDetail> GetToDoByID(int id)
        {
            return await this.toDoService.GetToDo(id);
        }

        [HttpPost(Name = "PostToDo")]
        public async Task<IActionResult> PostToDo(ToDoDetailsRequest todo)
        {
            if (todo == null)
            {
                return this.BadRequest("Invalid ToDoDetail object.");
            }

            var entity = new ToDoDetail
            {
                Title = todo.Title,
                Description = todo.Description,
                Date = todo.Date,
                IsCompleted = todo.IsCompleted,
                UserId = todo.UserId,
            };

            await this.toDoService.AddToDo(entity);
            return this.Ok();
        }

        [HttpDelete(Name = "DeleteToDo")]
        public async Task DeleteToDo(int todoId)
        {
            await this.toDoService.DeleteToDo(todoId);
        }
    }
}
