using System.Xml.Linq;

namespace havadurumu
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            var city = comboBox1.Text;

            //Baðlantý kýsmý
            string api = "6c8b51763fcff32a63a16f71abe70571";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q="+city.ToLower()+"&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument hava = XDocument.Load(connection);


            //Kaydedilen verileri çekme
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            var sehir = hava.Descendants("city").ElementAt(0).Attribute("name").Value;



            //Çekilen verileri yazdýrma
            lblSýcaklýk.Text = sicaklik.ToString();
            lblRuzgar.Text = ruzgar + " m/s";
            lblNem.Text = nem + " %";
            lblDurum.Text = durum.ToUpper();
            lblSehir.Text = sehir.ToString();



            //hava durumuna göre resim ekleme
            if (durum=="açýk")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_28;
                //pictureBox1.ImageLocation = @"C:\Users\ilker\Desktop\PNG\PNG Version 2\001lighticons-28.png";
            }
            
            if (durum=="az bulutlu")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_30;
            }

            if (durum=="kapalý")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_41;
            }

            if (durum=="hafif yaðmur")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_34;
            }
        }

        private void lblSehir_Click(object sender, EventArgs e)
        {

        }
    }
}