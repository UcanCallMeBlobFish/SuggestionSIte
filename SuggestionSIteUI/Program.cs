using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SuggestionSiteBack.DataAccess.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly;

using SuggestionSIteUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.ConfigureServices();
// builder.Services.AddRazorPages();
// builder.Services.AddServerSideBlazor();
// builder.Services.AddMemoryCache();
//         
//
// builder.Services.AddSingleton<IDbConnection, DbConnection>();
// builder.Services.AddSingleton<ICategoryData, MongoCategoryData>();
// builder.Services.AddSingleton<IStatusData, MongoStatusData>();
// builder.Services.AddSingleton<ISuggestionData, MongoSuggestionData>();
// builder.Services.AddSingleton<IUserData, MongoUserData>();
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
