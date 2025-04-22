using LocalBackend.Data;
using LocalBackend.Repositories.implementation;
using LocalBackend.Repositories.implementation.Dispositivo;
using LocalBackend.Repositories.implementation.Elementos;
using LocalBackend.Repositories.implementation.Eventos;
using LocalBackend.Repositories.implementation.Medicion;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalBackend.Repositories.Interfaces.Elementos;
using LocalBackend.Repositories.Interfaces.Eventos;
using LocalBackend.Repositories.Interfaces.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.implementation.Dispositivo;
using LocalBackend.Repositories.UnitsOfWork.implementation.Elementos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Eventos;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Elementos;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Eventos;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Mediciones;
using LocalBackend.Utilities;
using LocalShared.Entities.Dispositivos;
using LocalShared.Entities.Elementos;
using LocalShared.Entities.Eventos;
using LocalShared.Entities.Medicion;
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
builder.Services.AddScoped<IGenericUnitOfWork<ClsMTipoMedicion>, TipoMedicionUnitOfWork>();

builder.Services.AddScoped<IUnidadMedidaRepository, UnidadMedidaRepository>();
builder.Services.AddScoped<IUnidadMedidaUnitOfWork, UnidadMedidaUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMUnidadMedida>, UnidadMedidaUnitOfWork>();

builder.Services.AddScoped<IImpactoRepository, ImpactoRepository>();
builder.Services.AddScoped<IImpactoUnitOfWork, ImpactoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMImpacto>, ImpactoUnitOfWork>();

builder.Services.AddScoped<ITipoEventosRepository, TipoEventoRepository>();
builder.Services.AddScoped<ITipoEventoUnitOfWork, TipoEventoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMTipoEvento>, TipoEventoUnitOfWork>();

builder.Services.AddScoped<ITipoDispositivoRepository, TipoDispositivoRepository>();
builder.Services.AddScoped<ITipoDispositivoUnitOfWork, TipoDispositivoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMTipoDispositivo>, TipoDispositivoUnitOfWork>();

builder.Services.AddScoped<IDispositivoRepository, DispositivoRepository>();
builder.Services.AddScoped<IDispositivoUnitOfWork, DispositivoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMDispositivo>, DispositivoUnitOfWork>();

builder.Services.AddScoped<IEventoRepository, EventoRepository>();
builder.Services.AddScoped<IEventoUnitOfWork, EventoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMEvento>, EventoUnitOfWork>();

builder.Services.AddScoped<IElementoRepository, ElementoRepository>();
builder.Services.AddScoped<IElementoUnitOfWork, ElementoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMElemento>, ElementoUnitOfWork>();

builder.Services.AddScoped<ICantidadElementoRepository, CantidadElementoRepository>();
builder.Services.AddScoped<ICantidadElementoUnitOfWork, CantidadElementoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMCantidadElemento>, CantidadElementoUnitOfWork>();

builder.Services.AddScoped<ITipoElementoRepository, TipoElementoRepository>();
builder.Services.AddScoped<ITipoElementoUnitOfWork, TipoElementoUnitOfWork>();
builder.Services.AddScoped<IGenericUnitOfWork<ClsMTipoElemento>, TipoElementoUnitOfWork>();

//builder => builder.WithOrigins(/*"http://localhost:57871", "https://localhost:7223"*/"*")
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder =>
        {
            builder.WithOrigins("*").AllowAnyMethod();
            builder.WithOrigins("*").AllowAnyHeader();
            builder.WithOrigins("*").AllowCredentials();
        });
    }
);
builder.Services.AddAutoMapper(typeof(MappingProfile));

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
