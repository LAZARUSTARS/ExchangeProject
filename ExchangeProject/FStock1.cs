using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExchangeProject
{
    public partial class FStock1 : Form
    {
        public FStock1()
        {
            InitializeComponent();
        }

        private void FStock1_Load(object sender, EventArgs e)
        {
            


            //chart1.Series["Series1"].XValueMember = "Month";


            /*for (int i = 0; i < class2.Count; i++)
            {
                this.chart1.Series["Series1"].Points.AddXY(System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date, class2[i].UnitPrice1);
            }*/
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
    }
}
