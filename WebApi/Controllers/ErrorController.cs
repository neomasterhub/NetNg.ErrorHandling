using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Neomaster.Extensions.Exception;
using WebApi.ActivityTypes;

namespace WebApi.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : ApiControllerBase
{
    public ObjectResult Index()
    {
        var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
        var error = exceptionHandlerFeature.Error;
        var errorStack = error
            .GetAllInnerExceptions()
            .Select(e => new Error(e));

        return new ObjectResult(errorStack)
        {
            StatusCode = 500,
        };
    }
}
