using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Services.Services.Interfaces;
using SaludGestREST.Services.Services.Implementations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using SaludGestREST.Services.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var conncection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Conection string 'DeafaultConnection' ot foud");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conncection));
var app = builder.Build();

#region Services
builder.Services.AddScoped<IMedicamentoService, MedicamentoService>();
builder.Services.AddScoped<IPacienteService, PacienteService>();
#endregion

#region Settings
builder.Services.Configure<UploadSettings>(builder.Configuration.GetSection("UploadSettings"));
//builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
