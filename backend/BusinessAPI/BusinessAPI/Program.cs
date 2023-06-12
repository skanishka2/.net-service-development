var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/clocktest", () =>
{
    return "Hi There";
});

app.MapGet("/clock", () =>
{
    var response = new GetClockResponse(true, null);
    return Results.Ok(response);
});

app.Run();

public record GetClockResponse(bool IsOpen, DateTime? NextOpenTime);