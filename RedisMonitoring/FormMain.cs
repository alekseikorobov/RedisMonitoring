using RedisMonitoring.Dialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace RedisMonitoring;
public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
        memoryChart.Series.Clear();
        cpuChart.Series.Clear();

        var connected = false;
        try
        {
            configForm = new ConfigForm("config.json");
            connected = configForm.TryConnect();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        if (connected)
        {
            connectionStatusValueLabel.Text = "Connect";
            stopTimerToolStripMenuItem_Click(null, null);
        }
        else
        {
            connectionStatusValueLabel.Text = "Not Connect";
        }
    }

    ConfigForm configForm;
    int countView = 180;
    bool isStartTimer = false;

    private void configToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var res = configForm.ShowDialog();

        if (res == DialogResult.OK && configForm.Server != null)
        {
            connectionStatusValueLabel.Text = "Connect";
            stopTimerToolStripMenuItem_Click(null, null);
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if(configForm.Server == null){
            return;
        }
        var infoList = configForm.Server.Info();

        for (int i = 0; i < infoList.Length; i++)
        {
            IGrouping<string, KeyValuePair<string, string>> infoItemG = infoList[i];
            Dictionary<string, string> infoItem = infoItemG.Select(c => c).ToDictionary(c => c.Key, c => c.Value);

            switch (infoItemG.Key)
            {
                case "Server":
                    serverTextBox.Text = string.Join("\r\n", infoItem.Select(c => $"{c.Key}: {c.Value}"));
                    break;
                case "Stats":
                    statsTextBox.Text = string.Join("\r\n", infoItem.Select(c => $"{c.Key}: {c.Value}"));
                    break;
                case "Clients":
                    clientsTextBox.Text = string.Join("\r\n", infoItem.Select(c => $"{c.Key}: {c.Value}"));
                    break;
                case "Replication":
                    replicationTextBox.Text = string.Join("\r\n", infoItem.Select(c => $"{c.Key}: {c.Value}"));
                    break;
                case "Persistence":
                    persistenceTextBox.Text = string.Join("\r\n", infoItem.Select(c => $"{c.Key}:  {c.Value}"));
                    break;
                case "Memory":
                    memoryLabelValue.Text = string.Join("\r\n", infoItem
                        .Where(c => c.Key.Contains("human"))
                        .Select(c => $"{c.Key.Replace("_human", "")}:  {c.Value}"));

                    memoryTextBox.Text = string.Join("\r\n", infoItem.Select(c => $"{c.Key}:  {c.Value}"));

                    RefreshChart(memoryChart, infoItem, new[] { "used_memory", }, "maxmemory");

                    break;
                case "CPU":
                    cpuLabelValue.Text = string.Join("\r\n", infoItem.Select(c => $"{c.Key}:  {c.Value}"));

                    RefreshChart(cpuChart, infoItem, new[] { "used_cpu_sys", "used_cpu_user" }, 100);

                    break;
                default:
                    break;
            }
        }
    }

    private void RefreshChart(Chart chart, Dictionary<string, string> infoItem, string[] series, double valMax)
    {
        //chart.ChartAreas[0].AxisY.Maximum = valMax;
        //chart.ChartAreas[0].AxisY.Minimum = 0;
        foreach (var ser in series)
        {
            var valMem = double.Parse(infoItem[ser]);
            if (!chart.Series.Select(c => c.Name).Contains(ser))
            {
                var s1 = new Series(ser);
                s1.ChartType = SeriesChartType.Spline;
                chart.Series.Add(s1);
            }

            if (chart.Series[ser].Points.Count > countView)
                chart.Series[ser].Points.RemoveAt(0);

            chart.Series[ser].Points.AddY(valMem);

            var valMax1 = chart.Series[ser].Points.Max(c => c.YValues.Max());
            if (chart.ChartAreas[0].AxisY.Maximum < (valMax1 + valMax1 * 0.3))
            {
                chart.ChartAreas[0].AxisY.Maximum = (valMax1 + valMax1 * 0.3);
            }
        }
    }
    private void RefreshChart(Chart chart, Dictionary<string, string> infoItem, string[] series, string maxSeries)
    {
        var valMax = double.Parse(infoItem[maxSeries]);

        RefreshChart(chart, infoItem, series, valMax);
    }


    private void stopTimerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (isStartTimer)
        {
            timer1.Stop();
            stopTimerToolStripMenuItem.Text = "Start timer";
        }
        else
        {
            timer1.Start();
            stopTimerToolStripMenuItem.Text = "Stop timer";
        }
        isStartTimer = !isStartTimer;
    }
}
