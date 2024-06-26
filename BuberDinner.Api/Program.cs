using BuberDinner.Api;
using BuberDinner.Application;
using BuberDinner.Infrastructure;

//This container will be used to register all the services and dependencies
var builder = WebApplication.CreateBuilder(args);
{
    // Dependency Injection container for the application and infrastructure
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
