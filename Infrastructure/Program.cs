using Microsoft.EntityFrameworkCore;
using Murmur.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<MurmurDBContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Username=cage;Password=ducks;Database=murmur_db")
);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    using (var db = scope.ServiceProvider.GetService<MurmurDBContext>()!)
    {
        db.Database.EnsureCreated();
    }
}

app.UseHttpsRedirection();
app.Run();
