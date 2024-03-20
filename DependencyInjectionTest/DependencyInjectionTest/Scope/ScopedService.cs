namespace DependencyInjectionTest.API.Scope;

public class ScopedService: IScopedService
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Execute()
    {
        return $"Scoped Id: {Id}";

    }
}
