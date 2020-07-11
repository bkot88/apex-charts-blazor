using ApexCharts.Blazor.Configuration;
using ApexCharts.Blazor.Interop;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace ApexCharts.Blazor
{
    public class ApexChart : ComponentBase
    {
        [Inject]
        protected ILogger<ApexChart> Logger { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public string ChartId { get; set; }

        [Parameter]
        public ChartOptions Options { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Logger.LogInformation($"{nameof(ApexChart)}.{nameof(OnInitializedAsync)}()");
            await ApexChartsInterop.Init(JSRuntime, ChartId);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Logger.LogInformation($"{nameof(ApexChart)}.{nameof(OnAfterRenderAsync)}()");
            await ApexChartsInterop.Render(JSRuntime, ChartId, Options);
        }
    }
}
