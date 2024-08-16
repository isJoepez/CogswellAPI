
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.OpenApi.Models;
//[assembly: ApiController]

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.


builder.Services.AddSingleton<IDbConnect, DbConnect>();
builder.Services.AddSingleton<IIngredientData, IngredientData>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyTestService", Version = "v1", });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();



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
