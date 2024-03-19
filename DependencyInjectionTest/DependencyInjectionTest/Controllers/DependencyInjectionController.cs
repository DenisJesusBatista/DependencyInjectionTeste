using DependencyInjectionTest.API.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTest.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DependencyInjectionController : ControllerBase
{
    private readonly ISingletonService _singletonService;
    public DependencyInjectionController(ISingletonService singletonService)
    {
        _singletonService = singletonService;        
    }

    [HttpGet]   
    public IActionResult Get()
    {
        var result = _singletonService.Execute();

        return Ok(result);
    }
}
