using MipsPerformanceReader;
using MipsPerformanceReader.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPerformanceReportService, PerformanceReportService>();
builder.Services.AddScoped<INopAdditionService, NopAdditionService>();

await builder.Build().RunAsync();
