using Microsoft.AspNetCore.Mvc;
using WebApi.ActivityTypes;

namespace WebApi.Controllers;

public class TestController : ApiControllerBase
{
    [HttpGet]
    public JsonResult Index(int statusCode = 200)
    {
        return statusCode switch
        {
            200 => Json(new
            {
                Message = "Hello World!",
            }),
            _ => throw new MyException("Error 500"),
        };
    }
}
