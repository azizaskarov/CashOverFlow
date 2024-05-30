using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashOverFlow.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public string Get() => "Cash flows...";
}
