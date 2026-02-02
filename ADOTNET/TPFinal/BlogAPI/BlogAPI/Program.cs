using TPFinal.Class;
using Microsoft.EntityFrameworkCore;
using TPFinal.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var connectionString = "Server=localhost;Database=blog_db;Uid=root;Pwd=root;Port=3306;";
var serverVersion = new MySqlServerVersion(new Version(9, 0, 0));

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connectionString, serverVersion));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

