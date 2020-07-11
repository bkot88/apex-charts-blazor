# blazor-apex-charts
An incomplete Blazor JsInterop around Apex Charts. Nuget package coming soon..

## Getting Started
1. Reference BlazorApexCharts in your project
2. Add javascript script references to your index.html (client-side)
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
