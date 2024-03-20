using DependencyInjectionTest.API.Scope;
using DependencyInjectionTest.API.Singleton;
using DependencyInjectionTest.API.Transient;
using DependencyInjectionTest.API.UseCase;
using DependencyInjectionTest.API.UseCase.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddScoped<IScopedService, ScopedService>();

builder.Services.AddScoped<IUseCaseA, UseCaseA>();
builder.Services.AddScoped<IUseCaseB, UseCaseB>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
