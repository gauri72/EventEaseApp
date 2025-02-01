using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEaseApp;
using EventEaseApp.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Web;
using System.Net.Http;
using System;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register services
builder.Services.AddSingleton<UserSessionService>();
builder.Services.AddSingleton<AttendanceService>();

// Enable detailed error messages
builder.Logging.SetMinimumLevel(LogLevel.Debug);

await builder.Build().RunAsync();