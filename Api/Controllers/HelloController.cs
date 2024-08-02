using Api.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("hello")]
public class HelloController : ApplicationController
{
    [HttpGet]
    public IActionResult Hello()
    {
        return Ok("Hello, World!");
    }
}
