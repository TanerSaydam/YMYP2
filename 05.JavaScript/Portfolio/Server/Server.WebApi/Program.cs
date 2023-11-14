using DefaultCorsPolicyNugetPackage;
using Server.WebApi.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ApplicationDbContext>();

#region Ýstediðiniz ismi verebiliyorsunuz
builder.Services.AddDefaultCors();
#endregion

#region Presentation
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region Middleware
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();
#endregion

