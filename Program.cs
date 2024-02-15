using KB12938_IgbDataChart_IgbScatterSeries_MarkerColor;
using IgniteUI.Blazor.Controls;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor(
    typeof(IgbDataLegendModule),
    typeof(IgbCategoryChartModule)
    );

await builder.Build().RunAsync();
