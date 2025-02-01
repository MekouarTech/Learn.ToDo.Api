using Learn.ToDo.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Learn.ToDo.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection collection)
        {
            collection.AddDbContext<TodoContext>();
            collection.AddSingleton<TodoContext>();
            return collection;
        }
    }
}
