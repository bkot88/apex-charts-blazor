using System;
using System.Collections.Generic;

namespace BlazorApexCharts.Configuration
{
    public partial class ChartOptions
    {
        public List<Series> Series { get; set; }

        public Chart Chart { get; set; }

        public DataLabels DataLabels { get; set; }

        public Marker Markers { get; set; }

        public Title Title { get; set; }

        public Fill Fill { get; set; }

        public Stroke Stroke { get; set; }

        public Grid Grid { get; set; }

        public Yaxis Yaxis { get; set; }

        public Xaxis Xaxis { get; set; }

        public Tooltip Tooltip { get; set; }
    }

    public partial class Tooltip
    {
        public bool? Shared { get; set; }
        public Labels Y { get; set; }
    }

    public partial class Fill
    {
        public string Type { get; set; }

        public Gradient Gradient { get; set; }
    }

    public partial class Gradient
    {
        public decimal? ShadeIntensity { get; set; }

        public bool? InverseColors { get; set; }

        public decimal? OpacityFrom { get; set; }

        public decimal? OpacityTo { get; set; }

        public List<int> Stops { get; set; }
    }

    public partial class Marker
    {
        public int? Size { get; set; }
    }

    public partial class Chart
    {
        public string Type { get; set; }

        public bool? Stacked { get; set; }

        public decimal Height { get; set; }

        public Zoom Zoom { get; set; }

        public Toolbar Toolbar { get; set; }
    }

    public partial class Zoom
    {
        public string Type { get; set; }

        public bool? Enabled { get; set; }

        public bool? AutoScaleYAxis { get; set; }
    }

    public partial class Toolbar
    {
        public string AutoSelected { get; set; }
    }

    public partial class DataLabels
    {
        public bool Enabled { get; set; }
    }

    public partial class Grid
    {
        public Row Row { get; set; }
    }

    public partial class Row
    {
        public List<string> Colors { get; set; }

        public double Opacity { get; set; }
    }

    public partial class Series
    {
        public string Name { get; set; }

        public List<decimal> Data { get; set; }
    }

    public partial class Stroke
    {
        public string Curve { get; set; }
    }

    public partial class Title
    {
        public string Text { get; set; }

        public string Align { get; set; }
    }

    public partial class Xaxis
    {
        public string Type { get; set; }

        public List<string> Categories { get; set; }
    }

    public partial class Yaxis
    {
        public Title Title { get; set; }

        public Labels Labels { get; set; }
    }

    public partial class Labels
    {
        public Func<decimal, decimal> Formatter { get; set; }
    }
}
