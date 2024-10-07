








using Evim_API_WebApplication.Data;
using Evim_API_WebApplication.Interfaces;
using Evim_API_WebApplication.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



//builder.Services.AddDbContext<EngevDbContext>(
//    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr"))
//);

builder.Services.AddDbContext<EvimDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EvimDbContext")));

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddJwtSettings(builder.Configuration);
builder.Services.AddScoped<ISituationRepository, SituationRepository>();
builder.Services.AddScoped<IVarietyRepository, VarietyRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<INbhoodRepository, NbhoodRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
builder.Services.AddScoped<IAdvertisementRepository, AdvertisementRepository>();

builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddCors(cors => cors.AddDefaultPolicy(cors => cors.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
//API veya diðer web projelerimizin farklý orijinlerden yapýlacak taleplere cevap vermesini saðlar (same origin hatasýný vermesini engeller).



builder.Services.AddControllers();
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

app.Run();
