using ECommerce.API.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"));
});

builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.WithOrigins("http://localhost:3000");
    });
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();



app.Run();
