
using Business.Concrete;
using Business.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VehicleAPI.ApplicationContext;
using VehicleAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IVehicleRepository<>), typeof(VehicleRepository<>));
builder.Services.AddScoped<ICarRepository, CarManager>();
builder.Services.AddScoped<IBusRepository, BusManager>();
builder.Services.AddScoped<IBoatRepository, BoatManager>();

var configuration = builder.Configuration;
builder.Services.AddDbContext<VehicleDbContext>
                (options => options.UseSqlServer
                (configuration.GetConnectionString
                ("sqlConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);




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
