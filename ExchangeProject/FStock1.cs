using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExchangeProject
{
    public partial class FStock1 : Form
    {
        public FStock1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void FStock1_Load(object sender, EventArgs e)
        {
            
        }

        public void SetText(string label1text, string label5text, string label2text, string label6text)
        {
            label1.Text = label1text;
            label5.Text = label5text;
            label2.Text = label2text;

            long q = long.Parse(label6text);
            if (q > 1_000_000_000_000)
            {
                double s = q / 1_000_000_000_000.0;
                label6.Text = s.ToString() + " ТРЛН ₽";
            }
            else if (q > 100_000_000_000 & q < 1_000_000_000_000)
            {
                double s = q / 1_000_000_000.0;
                label6.Text = s.ToString() + " МЛРД ₽";
            }
        }

        public void SetChart(decimal[] arguments, string start, string end, string type)
        {
            chart1.Series["Cost"].Points.Clear();
            int minn = Convert.ToInt32(arguments.Min());
            this.chart1.Series["Cost"].BorderWidth = 3;
            this.chart1.ChartAreas[0].AxisY.Minimum = minn;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            if (type == "hourly")
            {
                DateTime current = DateTime.Now;
                for (int h = 0; h < arguments.Length; h++)
                {
                    
                    this.chart1.Series["Cost"].Points.AddXY(current.ToLongDateString(), arguments[h]);
                    current = current.AddHours(-1);
                }
            }
            if (type == "daily")
            {
                int i = 0;
                DateTime start1 = DateTime.Parse(start);
                DateTime end1 = DateTime.Parse(end);
                DateTime current = start1;
                while (current >= end1 && i < arguments.Length)
                {
                    if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday)
                    {
                        this.chart1.Series["Cost"].Points.AddXY(current.ToShortDateString(), arguments[i]);
                        i++;
                    }

                    current = current.AddDays(-1);
                }
            }
            
            this.chart1.ChartAreas[0].AxisX.IsReversed = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                chart1.Series["Cost"].Points.Clear();
                string startTime = DateTime.Today.ToString("yyyy-MM-dd"); ;
                string endTime = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                using (var client = new HttpClient())
                {
                    string url = "https://iss.moex.com/iss/engines/stock/markets/shares/securities/CHMF/candles.json?from=" + endTime + "&till=" + startTime + "&interval=60";
                    var endPoint = new Uri(url);
                    var result = client.GetAsync(endPoint).Result;
                    var json = result.Content.ReadAsStringAsync().Result;
                    var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
                    var dataArray = data["candles"].GetProperty("data");
                    decimal[] priceData = new decimal[dataArray.GetArrayLength()];
                    int k = 0;
                    int q = dataArray.GetArrayLength();
                    foreach (var item in dataArray.EnumerateArray())
                    {
                        decimal price = item[0].GetDecimal();
                        priceData[k] = price;
                        k++;
                    }

                    SetChart(priceData, startTime, endTime, "hourly");
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                chart1.Series["Cost"].Points.Clear();
                string startTime2 = DateTime.Today.ToString("yyyy-MM-dd"); ;
                string endTime2 = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd"); ;
                using (var client = new HttpClient())
                {
                    string url = "https://iss.moex.com/iss/engines/stock/markets/shares/securities/CHMF/candles.json?from=" + endTime2 + "&till=" + startTime2 + "&interval=24";
                    var endPoint = new Uri(url);
                    var result = client.GetAsync(endPoint).Result;
                    var json = result.Content.ReadAsStringAsync().Result;
                    var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
                    var dataArray = data["candles"].GetProperty("data");
                    decimal[] priceData = new decimal[dataArray.GetArrayLength()];
                    int k = 0;
                    int q = dataArray.GetArrayLength();
                    foreach (var item in dataArray.EnumerateArray())
                    {
                        decimal price = item[0].GetDecimal();
                        priceData[k] = price;
                        k++;
                    }

                    SetChart(priceData, startTime2, endTime2, "daily");
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                chart1.Series["Cost"].Points.Clear();
                string startTime3 = DateTime.Today.ToString("yyyy-MM-dd"); ;
                string endTime3 = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd"); ;
                using (var client = new HttpClient())
                {
                    string url = "https://iss.moex.com/iss/engines/stock/markets/shares/securities/CHMF/candles.json?from=" + endTime3 + "&till=" + startTime3 + "&interval=24";
                    var endPoint = new Uri(url);
                    var result = client.GetAsync(endPoint).Result;
                    var json = result.Content.ReadAsStringAsync().Result;
                    var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
                    var dataArray = data["candles"].GetProperty("data");
                    decimal[] priceData = new decimal[dataArray.GetArrayLength()];
                    int k = 0;
                    int q = dataArray.GetArrayLength();
                    foreach (var item in dataArray.EnumerateArray())
                    {
                        decimal price = item[0].GetDecimal();
                        priceData[k] = price;
                        k++;
                    }

                    SetChart(priceData, startTime3, endTime3, "daily");
                }
            }
        }
    }
}
