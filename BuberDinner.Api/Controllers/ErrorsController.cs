using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;


public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        // Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        // var (statusCode, message) = exception switch
        // {
        //     IError serviceException => ((int)serviceException.StatusCode, serviceException.ErrorMessage),
        //     _ => (StatusCodes.Status500InternalServerError, "An error occurred while processing your request.")
        
        // };
        
        return Problem();
    }

}