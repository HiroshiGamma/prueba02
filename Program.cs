using api02.src.data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string connectionString = Environment.GetEnvironmentVariable("DATABASE_URL") ?? "Data Source-app.db";
builder.Services.AddDbContext<ApplicationDBContext>(opt => opt.UseSqlite(connectionString));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();
