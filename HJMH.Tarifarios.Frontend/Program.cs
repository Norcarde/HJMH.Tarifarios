using CurrieTechnologies.Razor.SweetAlert2;
using HJMH.Tarifarios.Frontend;
using HJMH.Tarifarios.Frontend.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWX5feXVVQ2VfWUV/XUA=");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7114") });
builder.Services.AddSweetAlert2();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();