using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeProject
{
    public partial class FormStock1 : Form
    {
        public FormStock1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormStock1_Load(object sender, EventArgs e)
        {
            label2.Text = "Документация имеет ознакомительный характер. " + Environment.NewLine +
                "Все что вы увидите в этом приложении не является индивидуальной инвестиционной рекомендацией. " + Environment.NewLine +
                "Все цены указаны строго в рублевой валюте. Все совпадения случайны.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
