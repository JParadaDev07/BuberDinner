using BuberDinner.Api.Common.Errors;
using BuberDinner.Application;
using BuberDinner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

//This container will be used to register all the services and dependencies
var builder = WebApplication.CreateBuilder(args);
{
    // Dependency Injection container for the application and infrastructure
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    // Register the controllers
    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, BuberDinnerProblemDetailsFactory>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
