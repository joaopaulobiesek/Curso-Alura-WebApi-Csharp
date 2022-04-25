using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuariosAPI.Data;
using UsuariosAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<UserDbContext>(options =>
        options.UseSqlServer(connectionString));

builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>(opt =>
{
    opt.SignIn.RequireConfirmedEmail = true;
})
    .AddEntityFrameworkStores<UserDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<CadastroService, CadastroService>();
builder.Services.AddScoped<EmailService, EmailService>();
builder.Services.AddScoped<LoginService, LoginService>();
builder.Services.AddScoped<LogoutService, LogoutService>();
builder.Services.AddScoped<TokenService, TokenService>();

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
