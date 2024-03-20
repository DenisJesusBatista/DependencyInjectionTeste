using DependencyInjectionTest.API.UseCase.Interface;

namespace DependencyInjectionTest.API.UseCase;

public class UseCaseA: IUseCaseA
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Execute()
    {
        return $"Singleton UseCaseA_Id:  {Id}";
    }
}
