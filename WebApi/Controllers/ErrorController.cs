using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : ApiControllerBase
{
    public ObjectResult Index()
    {
        var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
        var error = exceptionHandlerFeature.Error;

        return Problem(
            statusCode: 500,
            title: error.Message,
            detail: error.StackTrace);
    }
}
