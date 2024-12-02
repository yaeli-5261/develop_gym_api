using Gym.Core.Entities;
using Gym.Core.Interface;
using Gym.Core.Repositories;
using Gym.Core.Services;
using Gym.Data;
using Gym.Data.Repositories;
using Gym.Service;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//מריץ את סוג השירות שמתעדכן
//builder.Services.AddSingleton<IDataContext, DataContext>();

builder.Services.AddScoped<IClientService,ClientService>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

builder.Services.AddScoped<ITrainerService, TrainerService>();
builder.Services.AddScoped<ITrainerRepository, TrainerRepository>();


builder.Services.AddScoped<ILessonService, LessonService>();
builder.Services.AddScoped<ILessonRepository, LessonRepository>();


//builder.Services.add<IDataContext,DataContext>();
builder.Services.AddSingleton<DataContext>();

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
