using System.Xml.Linq;

namespace havadurumu
{
    public partial class Form1 : Form
    {
        public Form1()
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

            //Ba�lant� k�sm�
            string api = "6c8b51763fcff32a63a16f71abe70571";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q="+city.ToLower()+"&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument hava = XDocument.Load(connection);


            //Kaydedilen verileri �ekme
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;



            //�ekilen verileri yazd�rma
            lblS�cakl�k.Text = sicaklik.ToString();
            lblRuzgar.Text = ruzgar + " m/s";
            lblNem.Text = nem + " %";
            lblDurum.Text = durum.ToString();



            //hava durumuna g�re resim ekleme
            if (durum=="a��k")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_28;
                //pictureBox1.ImageLocation = @"C:\Users\ilker\Desktop\PNG\PNG Version 2\001lighticons-28.png";
            }
            
            if (durum=="az bulutlu")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_30;
            }

            if (durum=="kapal�")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_41;
            }

            if (durum=="hafif ya�mur")
            {
                pictureBox1.Image = Properties.Resources._001lighticons_34;
            }
        }
    }
}