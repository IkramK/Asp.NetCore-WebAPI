using Microsoft.EntityFrameworkCore;
using My_Books.Data;
using My_Books.Data.Services;

var builder = WebApplication.CreateBuilder(args);
//Services
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DataConnection' not found.");
// Add services to the container.

builder.Services.AddControllers();
//Configue Db Context With Sql
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
//Adding local Services
builder.Services.AddTransient<BookService>();
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
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        // Seed the data
        AppDbIntializer.Seed(app);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}

app.Run();
