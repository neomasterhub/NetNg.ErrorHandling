using Microsoft.AspNetCore.Mvc;

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
            _ => throw new Exception("Error 500"),
        };
    }
}
