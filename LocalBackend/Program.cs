using LocalBackend.Data;
using LocalBackend.Repositories.implementation;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.implementation;
using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=SQLSERVER"));
builder.Services.AddTransient<SeedDb>();
builder.Services.AddScoped(typeof(IGenericUnitOfWork<>), typeof(GenericUnitOfWork<>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.WithOrigins("http://localhost:57871", "https://localhost:7223")
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials());
});


var app = builder.Build();
SeedData(app);

void SeedData(WebApplication app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory!.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<SeedDb>();
        service!.SeedAsync().Wait();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthorization();
app.MapControllers();
app.Run();
