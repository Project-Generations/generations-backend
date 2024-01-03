using Generations.DA;
using Generations.DA.Data;
using Generations.TeamManager.Interfaces;
using Generations.TeamManager.Services;

var builder = WebApplication.CreateBuilder(args);

//Dependency inversion
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<ITeam, TeamDA>();

// Add services to the container.
builder.Services.AddDbContext<DataContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var CorsDefaultUrl = builder.Configuration.GetValue<string>("CorsSettings:DefaultUrl");

//Cors policy
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins(CorsDefaultUrl).AllowAnyHeader().AllowAnyMethod();
        });
});

//Enforce lowercase urls
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<DataContext>();
    context.Database.EnsureCreated();
    DbSeeder.Initialize(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
