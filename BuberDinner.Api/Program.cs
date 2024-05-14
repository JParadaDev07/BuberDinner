using BuberDinner.Application;
using BuberDinner.Infrastructure;

//This container will be used to register all the services and dependencies
var builder = WebApplication.CreateBuilder(args);
{
    // Dependency Injection container for the application and infrastructure
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    // Register the controllers
    //builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
    builder.Services.AddControllers();

}

var app = builder.Build();
{
    //app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
