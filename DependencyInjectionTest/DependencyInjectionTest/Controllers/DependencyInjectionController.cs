using DependencyInjectionTest.API.Scope;
using DependencyInjectionTest.API.Singleton;
using DependencyInjectionTest.API.Transient;
using DependencyInjectionTest.API.UseCase.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionTest.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DependencyInjectionController : ControllerBase
{
    private readonly ISingletonService _singletonService;
    private readonly ITransientService _transientService;
    private readonly IScopedService _scopedService;
    private readonly IUseCaseA _useCaseA;
    private readonly IUseCaseB _useCaseB;


    public DependencyInjectionController(
        ITransientService transientService,
        ISingletonService singletonService,
        IScopedService scopedService,
        IUseCaseA useCaseA,
        IUseCaseB useCaseB)
    {
        _singletonService = singletonService; 
        _transientService = transientService;
        _scopedService = scopedService; 
        _useCaseA = useCaseA;
        _useCaseB = useCaseB;
    }

    [HttpGet]   
    public IActionResult Get()
    {
        //var result = _scopedService.Execute();
        var resultA = _useCaseA.Execute();
        var resultB = _useCaseB.Execute();

        return Ok();
    }
}
