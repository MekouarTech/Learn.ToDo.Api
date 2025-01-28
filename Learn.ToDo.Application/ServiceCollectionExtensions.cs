using Learn.ToDo.Application.Interfaces;
using Learn.ToDo.Application.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection collection)
        {
            collection.AddSingleton<IToDoService, ToDoService>();
            collection.AddSingleton<IMemoryCache, MemoryCache>();

            return collection;
        }
    }
}
