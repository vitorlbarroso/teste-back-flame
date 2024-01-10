using loja.api;
using loja.data.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//add config ef
var conectionStringMySql = "Server=localhost;Port=3306;initial catalog=lojaflame;uid=root;pwd=007987Pq";
builder.Services.AddDbContext<Context>(x => x.UseMySql(conectionStringMySql, ServerVersion.Parse("8.2.0 - MySQL Community Server")));
builder.Services.AddScoped<DbContext, Context>();

var startup = new Startup(builder.Configuration);

var app = builder.Build();

app.MapControllers();
startup.Configure(app, app.Environment);
app.Run();
