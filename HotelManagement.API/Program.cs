using FluentValidation.AspNetCore;
using HotelManagement.API.Middlewares;
using HotelManagement.Data;
using HotelManagement.Data.Repositories;
using HotelManagement.Service;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HotelManagement.Service.MappingProfiles;

var builder = WebApplication.CreateBuilder(args);

//AutoMapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new HotelMappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HotelManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelManagementDb")));
//Scoped Dependency Injection
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IHotelService, HotelService>();

//FluentValidation
builder.Services.AddControllers()
    .AddFluentValidation(fv =>
    {
        fv.RegisterValidatorsFromAssemblyContaining<Program>();
    });

var app = builder.Build();

//Exception Middleware
app.UseMiddleware<ExceptionMiddleware>();

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
