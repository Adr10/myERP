using Microsoft.EntityFrameworkCore;
using myERP.Data.contexts;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Añadimos la cedana de conexión al conteneder de dependencias
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<MyDbContext>(opciones =>
//    opciones.UseSqlServer(connectionString,
//    sqlServer => sqlServer.UseNetTopologySuite()));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MyDbContext>(opciones =>
{
    opciones.UseSqlServer(connectionString,
    sqlServer => sqlServer.UseNetTopologySuite());
    opciones.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

    builder.Services.AddAutoMapper(typeof(Program));  

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
