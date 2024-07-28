using GameStore.FrontEnd.Components;
using GameStore.FrontEnd.GameContext;
using GameStore.FrontEnd.GamesRepository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

builder.Services.AddDbContext<GameDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("SQL"));
});
builder.Services.AddScoped<IGamesRepository,GameRepository>();
builder.Services.AddScoped<GameRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();
