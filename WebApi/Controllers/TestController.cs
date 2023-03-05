#pragma warning disable SA1116
using Microsoft.AspNetCore.Mvc;
using WebApi.ActivityTypes;

namespace WebApi.Controllers;

public class TestController : ApiControllerBase
{
    [HttpGet]
    public IActionResult Index(int statusCode = 200)
    {
        return statusCode switch
        {
            200 => Json(new
            {
                Message = "Hello World!",
            }),
            400 => BadRequest(),
            401 => Unauthorized(),
            403 => Forbid(),
            _ => throw
                new MyException("1",
                    new AggregateException(
                        new MyException("2"),
                        new MyException("3"))),
        };
    }
}
