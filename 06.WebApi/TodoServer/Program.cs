var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(
        policy => policy
            .AllowAnyOrigin()//hangi sitelerin ulaþabileceðine izin verir
            .AllowAnyMethod() //hangi metotlarý kullanacaðýna izin verir. GET, POST vb.
            .AllowAnyHeader()); //Handi typelarýn kullanýlacaðýna izin verir. ContentType/text-json
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