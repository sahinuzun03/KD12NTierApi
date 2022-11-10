using KD12NTierApi.DataAccess.EntityFramework.Context;
using KD12NTierApi.Extension;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<KD12NTierDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("KD12NTierApi")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Scoped(); //IoC yap�land�r�lmas�nda bunun yerine bu �al��acak dedik.


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
