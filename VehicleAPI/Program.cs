using Business.Concrete;
using Business.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VehicleAPI.ApplicationContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.BuildServiceProvider();
// Add services to the container.
builder.Services.AddScoped(typeof(IVehicleRepository<>), typeof(VehicleRepository<>));
builder.Services.AddScoped<ICarRepository, CarManager>();
builder.Services.AddScoped<IBusRepository, BusManager>();
builder.Services.AddScoped<IBoatRepository, BoatManager>();

var configuration = builder.Configuration;

// Add DbContext to services
builder.Services.AddDbContext<VehicleDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
