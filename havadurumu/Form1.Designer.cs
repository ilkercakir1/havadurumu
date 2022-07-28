namespace havadurumu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSıcaklık = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRuzgar = new System.Windows.Forms.Label();
            this.lblNem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSıcaklık
            // 
            this.lblSıcaklık.AutoSize = true;
            this.lblSıcaklık.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSıcaklık.Location = new System.Drawing.Point(156, 156);
            this.lblSıcaklık.Name = "lblSıcaklık";
            this.lblSıcaklık.Size = new System.Drawing.Size(126, 59);
            this.lblSıcaklık.TabIndex = 0;
            this.lblSıcaklık.Text = "00.00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İstanbul",
            "Adana",
            "Adiyaman",
            "Afyon",
            "Agrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydin",
            "Balikesir",
            "Bilecik",
            "Bingol",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Canakkale",
            "Cankırı",
            "Corum",
            "Denizli",
            "Diyarbakir",
            "Edirne",
            "Elaziğ",
            "Erzincan",
            "Erzurum",
            "Eskisehir",
            "Gaziantep",
            "Giresun",
            "Gümüshane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "izmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kirklareli",
            "Kirsehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaras",
            "Mardin",
            "Mugla",
            "Mus",
            "Nevsehir",
            "Nigde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdag",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "sanlıurfa",
            "Usak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kirikkale",
            "Batman",
            "sirnak",
            "Bartin",
            "ardahan",
            "igdir",
            "yalova",
            "Karabuk",
            "Kilis",
            "Osmaniye",
            "Düzce",
            "london"});
            this.comboBox1.Location = new System.Drawing.Point(31, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Şehir Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sıcaklık ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rüzgar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nem";
            // 
            // lblRuzgar
            // 
            this.lblRuzgar.AutoSize = true;
            this.lblRuzgar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRuzgar.Location = new System.Drawing.Point(156, 226);
            this.lblRuzgar.Name = "lblRuzgar";
            this.lblRuzgar.Size = new System.Drawing.Size(73, 28);
            this.lblRuzgar.TabIndex = 10;
            this.lblRuzgar.Text = "Bugün";
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNem.Location = new System.Drawing.Point(156, 271);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(73, 28);
            this.lblNem.TabIndex = 11;
            this.lblNem.Text = "Bugün";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::havadurumu.Properties.Resources._001lighticons_02;
            this.pictureBox1.Location = new System.Drawing.Point(431, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurum.Location = new System.Drawing.Point(484, 236);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(73, 28);
            this.lblDurum.TabIndex = 13;
            this.lblDurum.Text = "Bugün";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarih.Location = new System.Drawing.Point(31, 103);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(94, 28);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "Bugün";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 332);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.lblRuzgar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSıcaklık);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSıcaklık;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblRuzgar;
        private Label lblNem;
        private PictureBox pictureBox1;
        private Label lblDurum;
        private Label lblTarih;
    }
}