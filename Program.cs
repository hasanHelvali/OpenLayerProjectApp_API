using BasarSoftProject1_API.Context;
using BasarSoftProject1_API.Entities;
using BasarSoftProject1_API.Interfaces;
using BasarSoftProject1_API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<MapContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(configuration => configuration.AddDefaultPolicy(policiy =>
policiy.WithOrigins("http://localhost:4200", "https://localhost:4200")
.AllowAnyHeader().AllowAnyMethod().AllowCredentials()));

//builder.Services.AddScoped(typeof(IMapCrudRepository<>),typeof(MapCrudRepository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors();
app.MapControllers();
app.Run();
