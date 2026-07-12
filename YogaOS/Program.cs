using Microsoft.EntityFrameworkCore;
using YogaOS.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<YogaOsDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("YogaOsDb")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/db/health", async (YogaOsDbContext db) =>
    await db.Database.CanConnectAsync()
        ? Results.Ok("Database connection OK")
        : Results.Problem("Cannot connect to database"));

app.Run();
