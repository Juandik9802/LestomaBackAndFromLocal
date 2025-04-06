using LocalBackend.Data;
using LocalBackend.Repositories.implementation;
using LocalBackend.Repositories.implementation.Dispositivo;
using LocalBackend.Repositories.implementation.Elementos;
using LocalBackend.Repositories.implementation.Eventos;
using LocalBackend.Repositories.implementation.Medicion;
using LocalBackend.Repositories.implementation.Medios;
using LocalBackend.Repositories.implementation.Sistema;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalBackend.Repositories.Interfaces.Mediciones;
using LocalBackend.Repositories.Interfaces.Medio;
using LocalBackend.Repositories.Interfaces.Sistema;
using LocalBackend.Repositories.UnitsOfWork.implementation.Dispositivo;
using LocalBackend.Repositories.UnitsOfWork.implementation.Elemento;
using LocalBackend.Repositories.UnitsOfWork.implementation.Eventos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.implementation.Medio;
using LocalBackend.Repositories.UnitsOfWork.implementation.Sistema;
using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elemento;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Medio;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Sistema;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=SQLSERVER"));
builder.Services.AddTransient<SeedDb>();
builder.Services.AddScoped(typeof(IGenericUnitOfWork<>), typeof(GenericUnitOfWork<>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<ITipoMedicionRepository, TipoMedicionRepository>();
builder.Services.AddScoped<ITipoMedicionUnitOfWork, TipoMedicionUnitOfWork>();

builder.Services.AddScoped<IUnidadMedidaRepository, UnidadMedidaRepository>();
builder.Services.AddScoped<IUnidadMedidaUnitOfWork, UnidadMedidaUnitOfWork>();

builder.Services.AddScoped<IImpactoRepository, ImpactoRepository>();
builder.Services.AddScoped<IImpactoUnitOfWork, ImpactoUnitOfWork>();

builder.Services.AddScoped<ITipoEventosRepository, TipoEventoRepository>();
builder.Services.AddScoped<ITipoEventoUnitOfWork, TipoEventoUnitOfWork>();

builder.Services.AddScoped<ITipoDispositivoRepository, TipoDispositivoRepository>();
builder.Services.AddScoped<ITipoDispositivoUnitOfWork, TipoDispositivoUnitOfWork>();

builder.Services.AddScoped<IDispositivoRepository, DispositivoRepository>();
builder.Services.AddScoped<IDispositivoUnitOfWork, DispositivoUnitOfWork>();

builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
builder.Services.AddScoped<IMarcaUnitOfWork, MarcaUnitOfWork>();

builder.Services.AddScoped<IEstadosDispositivoRepository, EstadosDispositivoRepository>();
builder.Services.AddScoped<IEstadosDispositivoUnitOfWork, EstadosDispositivosUnitOfWork>();

builder.Services.AddScoped<ITipoElementosRepository, TipoElementoRepository>();
builder.Services.AddScoped<ITipoElementoUnitOfWork, TipoElementoUnitOfWork>();

builder.Services.AddScoped<IElementoRepository, ElementoRepository>();
builder.Services.AddScoped<IElementoUnitOfWork, ElementoUnitOfWork>();

builder.Services.AddScoped<IMedioRepository, MedioRepository>();
builder.Services.AddScoped<IMedioUnitOfWork, MedioUnitOfWork>();

builder.Services.AddScoped<ISistemaRepository, SistemaRepository>();
builder.Services.AddScoped<ISistemaUnitOfWork, SistemaUnitOfwork>();

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
