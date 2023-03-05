using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class TestController : ApiControllerBase
{
    [HttpGet]
    public string Index()
    {
        return "Hello World!";
    }
}
