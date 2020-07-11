using ApexCharts.Blazor.Configuration;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace ApexCharts.Blazor.Interop
{
    public static class ApexChartsInterop
    {
        private const string ApexCharts = "apexChartsPoc";

        public static ValueTask Render(IJSRuntime jsRuntime, string chartId, ChartOptions chartOptions)
        {
            return jsRuntime.InvokeVoidAsync(
                $"{ApexCharts}.render", chartId, chartOptions);
        }

        public static ValueTask Init(IJSRuntime jSRuntime, string chartId)
        {
            return jSRuntime.InvokeVoidAsync(
                $"{ApexCharts}.init", chartId);
        }
    }
}
