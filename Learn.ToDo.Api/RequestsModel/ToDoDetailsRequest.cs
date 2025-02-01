// <copyright file="ToDoDetailsRequest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Learn.ToDo.Api.RequestsModel
{
    public class ToDoDetailsRequest
    {
        public int TodoId { get; set; }

        public int UserId { get; set; }

        public DateTime? Date { get; set; }

        public string? Description { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}
