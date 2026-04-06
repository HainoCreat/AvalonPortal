using Avalon.Application.Services.Books;
using Microsoft.Extensions.DependencyInjection;

namespace Avalon.Application.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices (this IServiceCollection service)
    {
        service.AddScoped<IBookService, BookService>();

        return service;
    }
}