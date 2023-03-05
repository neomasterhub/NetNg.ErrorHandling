using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class TestController : ApiControllerBase
{
    [HttpGet]
    public string Index(int statusCode = 200)
    {
        return statusCode switch
        {
            200 => "Hello World!",
            _ => throw new Exception("Error 500"),
        };
    }
}
