using ClienteChallenge.Datos;
using ClienteChallenge.Interfaces;
using ClienteChallenge.Models;
using log4net.Config;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var log4netConfig = new FileInfo("log4net.config");
XmlConfigurator.Configure(log4net.LogManager.GetRepository(Assembly.GetEntryAssembly()), log4netConfig);

// Add services to the container.
builder.Services.AddDbContext<ClienteChallengeContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Context"));
});
builder.Services.AddScoped<IClienteService, ClientesData>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
