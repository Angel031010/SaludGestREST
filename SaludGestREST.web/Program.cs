using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using SaludGestREST.Data;
using SaludGestREST.Services.Services.Interfaces;
using SaludGestREST.Services.Services.Implementations;
using SaludGestREST.Services.Settings;
using Serilog;
using SaludGestREST.Data.Models;

var builder = WebApplication.CreateBuilder(args);

//Configuracion serilog usar Syslog Telemetry
var betterStack = builder.Configuration.GetValue<string>("BetterStack");
var EndPoint = builder.Configuration.GetValue<string>("Telemetry:host");

// Configura Serilog para enviar logs a Better Stack usando HTTP
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.BetterStack(sourceToken: betterStack,
                         betterStackEndpoint: EndPoint)
    .MinimumLevel.Information()
    .CreateLogger();

Log.Information("¡Se inicio log desde program!");

//Añadir serilog como el proveedor de logging
builder.Host.UseSerilog();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var conncection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Conection string 'DeafaultConnection' ot foud");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conncection));
//Configurar Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();


#region Services
builder.Services.AddScoped<ICentroMedicoService, CentroMedicoService>();
builder.Services.AddScoped<IMedicamentoService, MedicamentoService>();
builder.Services.AddScoped<IPacienteService, PacienteService>();
builder.Services.AddScoped<IInventarioService, InventarioService>();
builder.Services.AddScoped<IEspecialidadService, EspecialidadService>();
builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();
#endregion

#region Settings
builder.Services.Configure<UploadSettings>(builder.Configuration.GetSection("UploadSettings"));
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
#endregion
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "Uploads") // Ajusta "Uploads" si está en otra subcarpeta
    ),
    RequestPath = "/Uploads"
});


app.UseAuthorization();

app.MapControllers();

app.Run();
