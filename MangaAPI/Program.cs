using AutoMapper;
using MangaAPI.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// to do postgre db context service add -> 
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<MangaAPI.Persistance.Mapper.AutoMapper>();
});
builder.Services.AddSingleton(config.CreateMapper());
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddPersistenceServices();

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
