using Minio;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner
builder.Services.AddControllers();

// Configurar o MinIO
builder.Services.AddSingleton<IMinioService, MinioService>();
builder.Services.Configure<MinioSettings>(builder.Configuration.GetSection("MinIOConnection"));

var app = builder.Build();

// Configurar o pipeline de requisições HTTP
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
