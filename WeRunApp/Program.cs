using WeRunApp.Client.Pages;
using Microsoft.FluentUI.AspNetCore.Components;
using WeRunApp.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WeRunApp.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddFluentUIComponents();


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlite("Data Source=mydatabase.db"));

//builder.Services.AddDbContext<AppDbContext>(options =>
 //   options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(WeRunApp.Client._Imports).Assembly);


//app.UseRouting();

//app.MapBlazorHub();

app.Run();