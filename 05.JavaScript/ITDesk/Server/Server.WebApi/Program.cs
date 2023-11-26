using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Server.WebApi.Constants;
using Server.WebApi.Context;
using Server.WebApi.Options;
using Server.WebApi.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Jwt>(builder.Configuration.GetSection("Jwt")); //options pattern
builder.Services.ConfigureOptions<JwtSetupOptions>();

builder.Services.AddCors(configure =>
{
    configure.AddDefaultPolicy(policy => policy.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
});

builder.Services.AddScoped<JwtProvider>();
builder.Services.AddScoped<AuthService>();

builder.Services.AddAuthentication().AddJwtBearer();

//string? connectionString = builder.Configuration.GetConnectionString("SqlServer");
string? connectionString = ContextConstants.ConnectionString;

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(connectionString);
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup =>
{
    var jwtSecuritySheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put **_ONLY_** yourt JWT Bearer token on textbox below!",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    setup.AddSecurityDefinition(jwtSecuritySheme.Reference.Id, jwtSecuritySheme);

    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecuritySheme, Array.Empty<string>() }
                });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.Use(async (context, next) =>
{
    try
    {
        await next(context);
    }
    catch (Exception ex)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync(JsonConvert.SerializeObject(new { ErrorMessage = ex.Message }));
    }    
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
