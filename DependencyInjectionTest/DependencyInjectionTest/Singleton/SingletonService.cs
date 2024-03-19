namespace DependencyInjectionTest.API.Singleton;

public class SingletonService: ISingletonService
{
    public Guid Id { get; set; }  = Guid.NewGuid();

    public string Execute()
    {
        return $"Singleton Id:  {Id}";        
    }
}
