using Azure.Communication.Email;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using WebService.Data;

// using WebService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ProFindContext>(options =>
    options.UseMySql(builder.Configuration["ConnectionStrings"], new MySqlServerVersion(new Version(8, 0, 27)))
        .LogTo(Console.WriteLine, LogLevel.Information).EnableSensitiveDataLogging().EnableDetailedErrors());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.CustomOperationIds(description =>
        description.TryGetMethodInfo(out var methodInfo) ? methodInfo.Name : null);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(o => o.SerializeAsV2 = true);
    app.UseSwaggerUI(c => c.DisplayOperationId());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();