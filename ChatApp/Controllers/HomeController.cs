using Microsoft.AspNetCore.Mvc;

namespace ChatApp;
[Route("api/[controller]")]
[ApiController]
public class HomeControllers : Controller
{
    [HttpGet]
    public string Get()
    {
        return "Hello World";
    }

}
