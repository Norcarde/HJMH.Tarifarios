using HJMH.Tarifarios.Backend.Data;
using HJMH.Tarifarios.Backend.Repositories.Implementations;
using HJMH.Tarifarios.Backend.Repositories.Interfaces;
using HJMH.Tarifarios.Backend.UnitsOfWork.Implementations;
using HJMH.Tarifarios.Backend.UnitsOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=DefaultConnection"));

// Register repositories
builder.Services.AddScoped<ICUPSRepository, CUPSRepository>();

// Register units of work
builder.Services.AddScoped<ICUPSUnitOfWork, CUPSUnitOfWork>();

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