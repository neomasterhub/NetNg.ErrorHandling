using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : ApiControllerBase
{
    public ObjectResult Index()
    {
        var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
        var error = exceptionHandlerFeature.Error;
        var errorModel = new ErrorModel
        {
            Message = error.Message,
        };

        return new ObjectResult(errorModel)
        {
            StatusCode = 500,
        };
    }
}
