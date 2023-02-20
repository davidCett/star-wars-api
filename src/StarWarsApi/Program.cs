using Microsoft.EntityFrameworkCore;
using StarWarsContext.Models;
using StarWarsRepository;
using StarWarsRepository.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StarWarsContext.Models.StarWarsContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddTransient<IRepository<Person>, Repository<Person>>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
