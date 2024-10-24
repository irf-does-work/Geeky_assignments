using System.Reflection;
using CardManagement.Infrastructure.Data;
using CardManagement.Infrastructure.Repositories;
using CardManagement.Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CardManagementContext>(x => 
    x.UseSqlServer(@"Server=localhost,1430;Database=CardManagementAPI;User Id=sa;Password=Pass@w0rd;TrustServerCertificate=true")    
    );

builder.Services.AddScoped<CardManagementContext>();

builder.Services.AddMediatR(x => {
    x.RegisterServicesFromAssembly(Assembly.Load("CardManagement.Application"));
});

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();


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
