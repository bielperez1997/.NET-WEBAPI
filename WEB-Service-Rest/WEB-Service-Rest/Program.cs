using Microsoft.EntityFrameworkCore;
using WEB_Service_Rest.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionStringMysql = builder.Configuration.GetConnectionString("ConnectionMysql");
builder.Services.AddDbContext<APIDbContext>(option => option.UseMySql(connectionStringMysql, ServerVersion.Parse("8.0.32"))
);
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
