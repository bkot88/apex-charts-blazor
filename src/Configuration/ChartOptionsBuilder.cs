using System.Collections.Generic;

namespace BlazorApexCharts.Configuration
{
    public static class ChartOptionsBuilder
    {
        public static ChartOptions ZoomableTimeseries(
            string symbol, List<string> dates, List<decimal> quotes)
        {
            return new ChartOptions
            {
                Series = new List<Series>
                {
                    new Series
                    {
                        Name = symbol,
                        Data = quotes
                    }
                },
                Chart = new Chart
                {
                    Type = "area",
                    Stacked = false,
                    Height = 550,
                    Zoom = new Zoom
                    {
                        Type = "x",
                        Enabled = true,
                        AutoScaleYAxis = true
                    },
                    Toolbar = new Toolbar
                    {
                        AutoSelected = "zoom"
                    }
                },
                DataLabels = new DataLabels
                {
                    Enabled = false
                },
                Markers = new Marker
                {
                    Size = 0
                },
                Title = new Title
                {
                    Text = symbol,
                    Align = "center"
                },
                Fill = new Fill
                {
                    Type = "gradient",
                    Gradient = new Gradient
                    {
                        ShadeIntensity = 1,
                        InverseColors = false,
                        OpacityFrom = 0.5m,
                        OpacityTo = 0,
                        Stops = new List<int> { 0, 90, 100 }
                    }
                },
                Yaxis = new Yaxis
                {
                    Title = new Title
                    {
                        Text = "Price"
                    }
                },
                Xaxis = new Xaxis
                {
                    Type = "datetime",
                    Categories = dates
                },
                Tooltip = new Tooltip
                {
                    Shared = false
                }
            };
        }
    }
}
