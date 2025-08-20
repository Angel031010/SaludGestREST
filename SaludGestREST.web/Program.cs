using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using SaludGestREST.Data;
using SaludGestREST.Services.Services.Interfaces;
using SaludGestREST.Services.Services.Implementations;
using SaludGestREST.Services.Settings;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        builder => builder
            .WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var conncection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Conection string 'DeafaultConnection' ot foud");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conncection));


#region Services
builder.Services.AddScoped<ICentroMedicoService, CentroMedicoService>();
builder.Services.AddScoped<IMedicamentoService, MedicamentoService>();
builder.Services.AddScoped<IPacienteService, PacienteService>();
builder.Services.AddScoped<IInventarioService, InventarioService>();
builder.Services.AddScoped<IEspecialidadService, EspecialidadService>();
#endregion

#region Settings
builder.Services.Configure<UploadSettings>(builder.Configuration.GetSection("UploadSettings"));
//builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
#endregion
var app = builder.Build();

// Usar CORS
app.UseCors("AllowAngularApp");

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
