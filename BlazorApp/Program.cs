using BlazorApp.Authentication;
using BlazorApp.Components;
using BlazorApp.Services;
using Domain_Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // GetAllHeadsets from the Postgres DB
            IConfiguration Configuration = builder.Configuration;
            var connectionString = Configuration.GetConnectionString("DefaultConnection") ??
                                   Environment.GetEnvironmentVariable("DefaultConnection");
            builder.Services.AddSingleton<List<Headset>>(sp => new DatabaseService(connectionString).GetAllHeadsets());

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Authentication (login)
            builder.Services.AddAuthenticationCore();
            builder.Services.AddScoped<ProtectedSessionStorage>();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            builder.Services.AddSingleton<UserAccountService>();

            // Cookies
            builder.Services.AddScoped<ICookie, Cookie>();

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
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();

        }
    }
}
