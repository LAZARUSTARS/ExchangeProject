using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ExchangeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RoundButton docTep = new RoundButton();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            FormStock1 doc = new FormStock1();
            doc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FStock1 form1 = new FStock1();
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
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt64(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            string label1Text = class2[0].Name.ToString();
            string label5Text = class2[0].Evebitda.ToString();
            string label2Text = class2[0].Description.ToString();
            string label6Text = class2[0].CurrentCap.ToString();
            form1.SetText(label1Text, label5Text, label2Text, label6Text);

            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FStock1 form2 = new FStock1();
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
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt64(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            string label1Text = class2[1].Name.ToString();
            string label5Text = class2[1].Evebitda.ToString();
            string label2Text = class2[1].Description.ToString();
            string label6Text = class2[1].CurrentCap.ToString();
            form2.SetText(label1Text, label5Text, label2Text, label6Text);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FStock1 form4 = new FStock1();

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
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt64(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            string label1Text = class2[3].Name.ToString();
            string label5Text = class2[3].Evebitda.ToString();
            string label2Text = class2[3].Description.ToString();
            string label6Text = class2[3].CurrentCap.ToString();
            form4.SetText(label1Text, label5Text, label2Text, label6Text);

            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FStock1 form3 = new FStock1();

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
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt64(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            string label1Text = class2[2].Name.ToString();
            string label5Text = class2[2].Evebitda.ToString();
            string label2Text = class2[2].Description.ToString();
            string label6Text = class2[2].CurrentCap.ToString();
            form3.SetText(label1Text, label5Text, label2Text, label6Text);

            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FStock1 form6 = new FStock1();

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
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt64(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            string label1Text = class2[5].Name.ToString();
            string label5Text = class2[5].Evebitda.ToString();
            string label2Text = class2[5].Description.ToString();
            string label6Text = class2[5].CurrentCap.ToString();
            form6.SetText(label1Text, label5Text, label2Text, label6Text);

            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FStock1 form5 = new FStock1();

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
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt64(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            string label1Text = class2[4].Name.ToString();
            string label5Text = class2[4].Evebitda.ToString();
            string label2Text = class2[4].Description.ToString();
            string label6Text = class2[4].CurrentCap.ToString();
            form5.SetText(label1Text, label5Text, label2Text, label6Text);

            form5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FStock1 form7 = new FStock1();

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
                    class2.Add(new Exchange(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4), rd1.GetInt64(5), rd1.GetDecimal(6), rd1.GetDecimal(7), rd1.GetDecimal(8), rd1.GetDecimal(9), rd1.GetDecimal(10), rd1.GetDecimal(11), rd1.GetDecimal(12), rd1.GetDecimal(13), rd1.GetDecimal(14), rd1.GetDecimal(15), rd1.GetDecimal(16), rd1.GetDecimal(17), rd1.GetDecimal(18), rd1.GetDecimal(19), rd1.GetDecimal(20), rd1.GetDecimal(21), rd1.GetDecimal(22), rd1.GetDecimal(23), rd1.GetDecimal(24), rd1.GetDecimal(25), rd1.GetDecimal(26)));
                }
            }
            connection.Close();

            string label1Text = class2[6].Name.ToString();
            string label5Text = class2[6].Evebitda.ToString();
            string label2Text = class2[6].Description.ToString();
            string label6Text = class2[6].CurrentCap.ToString();
            form7.SetText(label1Text, label5Text, label2Text, label6Text);

            form7.Show();
        }
    }
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
