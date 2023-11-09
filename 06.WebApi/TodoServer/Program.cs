var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(
        policy => policy
            .AllowAnyOrigin()//hangi sitelerin ula�abilece�ine izin verir
            .AllowAnyMethod() //hangi metotlar� kullanaca��na izin verir. GET, POST vb.
            .AllowAnyHeader()); //Handi typelar�n kullan�laca��na izin verir. ContentType/text-json
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