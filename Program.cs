using mediatr_test;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediator(typeof(Program).Assembly);

builder.Services.AddScoped<ScopedService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
