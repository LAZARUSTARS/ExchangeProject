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

namespace ExchangeProject
{
    public partial class FStock1 : Form
    {
        public FStock1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FStock1_Load(object sender, EventArgs e)
        {
            List<Exchange> class2 = new List<Exchange>();
            SQLiteConnection connection = new SQLiteConnection("Integrated Security = SSPI; Data Source = MoexDB.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"SELECT  idstock, name, description, ticker, logo, currentCap, evebitda, price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20 FROM Exchange";
            using (var rd1 = command.ExecuteReader())
            {
                int k = 0;
                while (rd1.Read())
                {
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt32(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            //chart1.Series["Series1"].XValueMember = "Month";


            /*for (int i = 0; i < class2.Count; i++)
            {
                this.chart1.Series["Series1"].Points.AddXY(System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date, class2[i].UnitPrice1);
            }*/
        }
    }
}
