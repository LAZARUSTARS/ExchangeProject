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
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FStock1 form2 = new FStock1();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FStock1 form4 = new FStock1();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FStock1 form3 = new FStock1();
            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FStock1 form6 = new FStock1();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FStock1 form5 = new FStock1();
            form5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FStock1 form7 = new FStock1();
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
