using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.Json;
using System.Net.Http;


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

        private void getJsonData(string ticker, FStock1 form)
        {
            string startTime = DateTime.Today.ToString("yyyy-MM-dd"); ;
            string endTime = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            using (var client = new HttpClient())
            {
                string url = "https://iss.moex.com/iss/engines/stock/markets/shares/securities/" + ticker + "/candles.json?from=" + endTime + "&till=" + startTime + "&interval=60";
                var endPoint = new Uri(url);
                var result = client.GetAsync(endPoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
                var dataArray = data["candles"].GetProperty("data");
                decimal[] priceData = new decimal[dataArray.GetArrayLength()];
                string[] timeArray = new string[dataArray.GetArrayLength()];
                int k = 0;
                int q = dataArray.GetArrayLength();
                foreach ( var item in dataArray.EnumerateArray()) 
                {
                    decimal price = item[0].GetDecimal();
                    priceData[k] = price;
                    string time = item[item.GetArrayLength() - 1].GetString();
                    timeArray[k] = time;
                    k++;
                }

                form.SetChart(priceData, startTime, endTime, "hourly", timeArray);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FStock1 form1 = new FStock1();
            getJsonData("CHMF", form1);
            form1.SetText("Северсталь", "CHMF", "3.67", "ПАО Северсталь, которая раньше называлось ОАО Северсталь, — это расположенная в России компания, работающая в сталелитейной индустрии. У компании есть три подразделения: ресурсы, российская сталь и международные ресурсы. Подразделение ресурсов фокусируется на производстве железной руды и коксующегося угля; подразделение российской стали специализируется на листовом, длинном и трубопрокате для разных целей; международное подразделение — это стальной актив компании в США.", "1540000000000");

            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FStock1 form2 = new FStock1();
            getJsonData("SBER", form2);
            form2.SetText("Сбер", "SBER", "none", "ПАО «СберБанк России» занимается оказанием банковских и финансовых услуг. Компания ведет корпоративную и розничную банковскую деятельность, предлагая такие услуги, как: корпоративные займы, управление активами, зарплатные проекты, лизинг, онлайн-банкинг и, среди прочего, расчетно-кассовое обслуживание. Кроме того, СберБанк оказывает широкий спектр услуг для финансовых учреждений, в том числе корреспондентские счета, депозитарные услуги, межбанковское кредитование и др.", "6910000000000");

            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FStock1 form4 = new FStock1();
            getJsonData("YNDX", form4);
            form4.SetText("Яндекс", "YNDX", "9.94", "Yandex NV предоставляет поисковые системы и онлайн-сервисы. Компания осуществляет свою деятельность посредством следующих сегментов: Поиск и портал, Яндекс.Маркет, Такси, Медиасервисы, Реклама и Прочее. Сегмент поиска и интернет-порталов включает все услуги, предлагаемые в России, Беларуси и Казахстане. Сегмент такси охватывает сферу, связанную с поездками — например, Яндекс.Такси и Uber в России и других странах.", "1280000000000");

            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FStock1 form3 = new FStock1();
            getJsonData("TCSG", form3);
            form3.SetText("Тинькофф", "TCSG", "none", "TCS Group Holding PLC, также известный как «Тинькофф Банк», — холдинг, предоставляющий розничные банковские онлайн-услуги на территории России. Компания осуществляет свою деятельность посредством следующих сегментов: Дебетовые карты, Тинькофф Страхование, Услуги для малого и среднего бизнеса, Потребительское финансирование, Платежи, Тинькофф Инвестиции и Тинькофф Мобайл (MVNO).", "626820000000");

            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FStock1 form6 = new FStock1();
            getJsonData("TATN", form6);
            form6.SetText("Татнефть", "TATN", "4.06", "ПАО «Татнефть» является недропользователем, оператором и поставщиком нефтегазовых ресурсов, а также производителем нефтехимической продукции. Компания работает в трех сегментах: разведка и добыча; нефтепереработка и сбыт, а также нефтехимическая продукция. Сегмент разведки и добычи состоит из разведки, разработки, добычи и продажи собственной нефти.", "1650000000000");
            
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FStock1 form5 = new FStock1();
            getJsonData("ROSN", form5);
            form5.SetText("Роснефть", "ROSN", "1.94", "ПАО НК «Роснефть» занимается исследованием, освоением, добычей и продажей нефти и газа. Помимо этого, компания осуществляет мероприятия по переработке, транспортировке и продаже нефтепродуктов. Роснефть реализует свою деятельность через следующие бизнес-сегменты: Исследование и добыча, Переработка и сбыт, а также Корпоративный и прочее.", "6130000000000");

            form5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FStock1 form7 = new FStock1();
            getJsonData("UNAC", form7);
            form7.SetText("ОАК", "UNAC", "18.9", "ПАО «Объединённая авиастрои́тельная корпорация» («ОАК») — российская авиастроительная корпорация, одна из крупнейших в Европе. Объединяет крупные авиастроительные предприятия России. Зарегистрирована 20 ноября 2006 года (до апреля 2015 года называлась ОАО «ОАК»).", "792000000000");

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
