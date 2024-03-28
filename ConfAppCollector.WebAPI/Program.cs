using ConfAppCollector.Infrastructure.Core;
using ConfAppCollector.Infrastructure.Core.Implementations;
using ConfAppCollector.Infrastructure.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using ConfAppCollector.Application;
using ConfAppCollector.Application.Interfaces;
using ConfAppCollector.Application.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var configuration = builder.Configuration;
builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        options.UseNpgsql(configuration.GetConnectionString(nameof(AppDbContext)));
    }
);
builder.Services.AddScoped<ISpeakerRepository, SpeakerRepository>();
builder.Services.AddScoped<ICreateSpeakerAppUseCase, CreateSpeakerAppUseCase>();

builder.Services.AddSwaggerGen();




var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
