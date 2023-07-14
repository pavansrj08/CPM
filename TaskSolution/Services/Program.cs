using BusinessLogic;
using DataFluentAPI;
using DataFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TaskContext>(options => options.UseSqlServer("Server=BHANU\\SQLEXPRESS;Database=Task;Trusted_Connection=True;Encrypt=false;"));

builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<ICategoryLogic, CategoryLogic>();

builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IProductLogic, ProductLogic>();

builder.Services.AddScoped<IProductParameterRepo, ProductParameterRepo>();
builder.Services.AddScoped<IProductParameterLogic, ProductParameterLogic>();


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
