using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PaymentGateway.Application.Query;
using PaymentGateway.Application.QueryHandler;
using PaymentGateway.Application.Repository;
using PaymentGateway.Infrastructure;
using PaymentGateway.Infrastructure.Mapper;
using PaymentGateway.Infrastructure.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//configuration of my services as samwel.kilala

// Configuration of AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<PaymentDbContext>(Options=>Options.UseSqlServer(builder.Configuration.GetConnectionString("FTCSCS")));
builder.Services.AddScoped<IpaymentRepository,paymentRepository>();
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblyContaining<GetAllQueryHandler>(); });

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
