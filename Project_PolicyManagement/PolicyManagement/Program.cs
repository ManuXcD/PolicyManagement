using Microsoft.EntityFrameworkCore;
using PolicyManagement.Infra;
using PolicyManagement.Infra.Interfaces;
using PolicyManagement.Infra.Repositories;
using PolicyManagement.Services.Implementations;
using PolicyManagement.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<PolicyManagementDBContext>(option =>
{
    option.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPolicyService, PolicyService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
var app = builder.Build();

// add swagger for api documentation in development environment


app.UseAuthorization();

app.MapControllers();

app.Run();
