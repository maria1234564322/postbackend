using Application.CostCalculation; // Перевірте, що це правильний неймспейс
using Application.CostСalculation;
using Application.IServices;
using Application.Services;
using DataAccess.Repositories;
using DataAccess.Repostories.Animal;
using DataAccess.Repostories.DbClients;
using DataAccess.Repostories.DbDocuments;
using DataAccess.Repostories.DbIndexs;
using DataAccess.Repostories.DbLocations;
using DataAccess.Repostories.Order;
using DataAccess.Repostories.Orders;
using DataAccess.Repostories.Parcels;
using DataAccess.Repostories.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Web.Host;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//user
builder.Services.AddTransient<UserService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();
//parsel
builder.Services.AddScoped<IDbParcelRepository, DbParcelRepository>();
//order
builder.Services.AddScoped<IDbOrderRepository, DbOrderRepository>();
builder.Services.AddScoped<IOrdersService, OrdersService>();
// IIndex
builder.Services.AddScoped<IIndexService, IndexService>();
builder.Services.AddScoped<IIndexRepository, IndexRepository>();
//Location
builder.Services.AddScoped<IDbLocationRepository, DbLocationRepository>();
//Document
builder.Services.AddScoped<IDbDocumentRepository, DbDocumentRepository>();
//Client
builder.Services.AddScoped<IDbClientRepository, DbClientRepository>();
//Enimal
builder.Services.AddScoped<IDbAnimalRepository, DbAnimalRepository>();


builder.Services.AddTransient<ICostCalculation, CostCalculationService>(); // Правильні типи
builder.Services.AddDbContext<ApplicationDbContext>(b => b.UseSqlite("Data Source=C:\\Databases\\UserDb.db;"));
builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = AuthOptions.ISSUER,
            ValidAudience = AuthOptions.AUDIENCE,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AuthOptions.KEY))
        };
    });
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[]{}
        }
    });
});



var app = builder.Build();
app.UseCors(builder => builder.WithOrigins(
    "http://localhost:3000/")
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
