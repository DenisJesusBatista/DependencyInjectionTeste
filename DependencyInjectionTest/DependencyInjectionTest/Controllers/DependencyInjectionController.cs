using DependencyInjectionTest.API.Singleton;
using DependencyInjectionTest.API.Transient;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTest.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DependencyInjectionController : ControllerBase
{
    private readonly ISingletonService _singletonService;
    private readonly ITransientService _transientService;

    public DependencyInjectionController(
        ITransientService transientService,
        ISingletonService singletonService)
    {
        _singletonService = singletonService; 
        _transientService = transientService;
    }

    [HttpGet]   
    public IActionResult Get()
    {
        var result = _transientService.Execute();

        return Ok(result);
    }
}
