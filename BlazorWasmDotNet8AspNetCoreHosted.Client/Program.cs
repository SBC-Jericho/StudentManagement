using Blazored.LocalStorage;
using BlazorWasmDotNet8AspNetCoreHosted.Client;
using BlazorWasmDotNet8AspNetCoreHosted.Client.ClientServices.ClientAuthService;
using BlazorWasmDotNet8AspNetCoreHosted.Client.ClientServices.ClientBookService;
using BlazorWasmDotNet8AspNetCoreHosted.Client.ClientServices.ClientProfessorService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IClientAuthService, ClientAuthService>();
builder.Services.AddScoped<IClientBookService, ClientBookService>();
builder.Services.AddScoped<IClientProfessorService, ClientProfessorService>();
builder.Services.AddScoped<IClientAuthService, ClientAuthService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddMudServices();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();

