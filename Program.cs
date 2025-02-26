using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using BTG_CRM.Common;
using BTG_CRM.DbConnect;
using BTG_CRM.DbConnecter;
using BTG_CRM.Helper;

using BTG_CRM.DataAccessLayer;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var Configuration = builder.Configuration;

APIConfig.Configuration = Configuration;

APIConfig.WebRootPath = builder.Environment.WebRootPath;


//builder.Services.AddDbContext<ContextCore>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<ContextCore>(options => options.UseSqlServer(APIConfig.Configuration.GetSection("ConnectionStrings")["DefaultConnection"]));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IConnection, ConnectionFactory>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


builder.Services.AddMvcCore().AddApiExplorer();





builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy",
        builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
            );
});

builder.Services.AddMvc().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    options.SerializerSettings.ContractResolver = new LowercaseContractResolver();
});

var app = builder.Build();
app.UseCors("CorsPolicy");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ApiMiddleware>();


app.UseHttpsRedirection();

app.UseStaticFiles();


//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(
//           Path.Combine(builder.Environment.ContentRootPath, "wwwroot/UploadedReels")),
//    RequestPath = "/UploadedReels"
//});


app.UseAuthorization();
app.MapControllers(); app.Run();
