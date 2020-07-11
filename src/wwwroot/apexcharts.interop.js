// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.apexChartsPoc = {
    charts: {},

    /**
     * Render an Apex Chart
     * @param {any} chartId
     * @param {any} options
     */
    render: function (chartId, options) {
        if (!options) {
            // nothing to do
            return;
        }

        console.log(options);

        let chart = this.charts[chartId];

        if (chart) {
            // we update
            chart.updateOptions(options);
        }
        else {
            // we render
            chart = new ApexCharts(document.getElementById(chartId), options);
            chart.render();
            // add to collection
            this.charts[chartId] = chart;
        }
    },

    /**
     * Should only be called once
     * @param {any} chartId
     */
    init: function (chartId) {
        this.charts[chartId] = null;
    }
}
