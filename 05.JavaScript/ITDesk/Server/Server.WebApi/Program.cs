using Microsoft.EntityFrameworkCore;
using Server.WebApi.Constants;
using Server.WebApi.Context;
using Server.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(configure =>
{
    configure.AddDefaultPolicy(policy => policy.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
});

builder.Services.AddScoped<AuthService>();

//string? connectionString = builder.Configuration.GetConnectionString("SqlServer");
string? connectionString = ContextConstants.ConnectionString;

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(connectionString);
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
