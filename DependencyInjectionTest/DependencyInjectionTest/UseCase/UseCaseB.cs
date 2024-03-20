using DependencyInjectionTest.API.UseCase.Interface;

namespace DependencyInjectionTest.API.UseCase;

public class UseCaseB : IUseCaseB
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Execute()
    {
        return $"Singleton UseCaseB_Id:  {Id}";
    }
}
