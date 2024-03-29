using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TestAPIcall.Data;
using Refit;
using TestAPIcall.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddRefitClient<IGuestData>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://localhost:44312/api");
}
);
//builder.Services.AddRefitClient<IAPiData>().ConfigureHttpClient(c =>
//{
//    c.BaseAddress = new Uri("https://api.publicapis.org");
//}
//);
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
