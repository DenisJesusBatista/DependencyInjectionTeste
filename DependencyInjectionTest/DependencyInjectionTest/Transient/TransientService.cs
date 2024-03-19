namespace DependencyInjectionTest.API.Transient;

public class TransientService: ITransientService
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Execute()
    {
        return $"Transient Id: {Id}";
        
    }
}
