using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using ULO;
using ULO.UI.Components;

var builder = WebApplication.CreateBuilder(args);

//  Rejestracja komponentów Razor i Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options => { options.DetailedErrors = true; });

//  Uwierzytelnianie i autoryzacja
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "auth_token";
        options.LoginPath = "/LoginPage";
        options.Cookie.MaxAge = TimeSpan.FromMinutes(366);
        options.AccessDeniedPath = "/Error";
    });

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();

//  Rejestracja kontekstu bazy danych
builder.Services.AddDbContext<ULODbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ULODbConnection")));

builder.Services.AddAntiforgery();

var app = builder.Build();

//  Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage(); //  dodane tylko w Dev
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

//  Mapowanie komponentów Blazor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
