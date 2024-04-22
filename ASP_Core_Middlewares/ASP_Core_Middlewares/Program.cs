using ASP_Core_Middlewares.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => options.Filters.Add<LogActivityFilter>());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server = WALID\\MSSQLSERVER02; Database = Products; Trusted_Connection = True; TrustServerCertificate = True;"));
builder.Services.AddScoped<IProduct, ProductRepo>();
builder.Services.AddAuthentication()
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("Basic",null);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ProfilingMiddelware>();
app.UseMiddleware<RateLimitingMiddleware>(); 

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();


app.Run();


