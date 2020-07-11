# blazor-apex-charts
An incomplete Blazor JsInterop around Apex Charts. Nuget package coming soon..

## Getting Started
1. Reference BlazorApexCharts in your project
2. Add javascript script references to your `index.html` (client-side)
```html
...
<script src="https://cdn.jsdelivr.net/npm/apexcharts"></script>
<script src="_content/BlazorApexCharts/apexcharts.interop.js"></script>
...
```
3. Add component in your .razor page
```csharp
<BlazorApexCharts.ApexChartComponent ChartId="sample-chart" Options="Options" />

@code {
    public BlazorApexCharts.Configuration.ChartOptions Options { get; set; }

    protected override void OnInitialized()
    {
        Options = BlazorApexCharts.Configuration.ChartOptionsBuilder.ZoomableTimeseries(
            "Desktops",
            new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" },
            new List<decimal> { 10, 41, 35, 51, 49, 62, 69, 91, 148 });

        // default is set to datetime, we remove here
        Options.Xaxis.Type = null;
    }
}
```
4. Temporary work-around to `JsonSerializerOptions` to ensure we don't serialise null values when passing C# objects to `IJSRuntime` in. Add the snippet in `Program.cs` until microsoft allow us to modify it.
```csharp
...
var host = builder.Build();
var jsRuntime = host.Services.GetRequiredService<IJSRuntime>();
var prop = typeof(JSRuntime).GetProperty("JsonSerializerOptions", BindingFlags.NonPublic | BindingFlags.Instance);
JsonSerializerOptions value = (JsonSerializerOptions)Convert.ChangeType(prop.GetValue(jsRuntime, null), typeof(JsonSerializerOptions));
value.IgnoreNullValues = true;
...
```