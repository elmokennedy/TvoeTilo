using Microsoft.EntityFrameworkCore;
using TvoeTilo.Infrastructure.DataAccess.DbContexts;
using TvoeTilo.Infrastructure.DataAccess.Repositories;
using TvoeTilo.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITvoeTiloDbContext, TvoeTiloDbContext>();

builder.Services.AddTransient<IClientRepository, ClientRepository>();

builder.Services.AddTransient<IClientService, ClientService>();


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
