using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace josephus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int butonGenislik = 60;
        private const int butonYukseklik = 60;
        private const int aralik = 10;
        private const int maksimumCakismaDenemeSayisi = 10;


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listBox1.Items.Clear();
            int oyuncuSayisi = (int)playerCount.Value;
            List<Oyuncu> oyuncular = new List<Oyuncu>();
            List<Button> oyuncuButonlari = new List<Button>();

            int centerX = panel1.Width / 2;
            int centerY = panel1.Height / 2;

            double angle = 0;
            double angleIncrement = 2 * Math.PI / oyuncuSayisi;

            double panelAspect = (double)panel1.Width / panel1.Height;

            for (int i = 1; i <= oyuncuSayisi; i++)
            {
                oyuncular.Add(new Oyuncu(i));

                Button oyuncuButton = new Button();
                oyuncuButton.Text = $"Oyuncu {i}";
                oyuncuButton.ForeColor = Color.White;
                oyuncuButton.Tag = i;
                oyuncuButton.Size = new Size(butonGenislik, butonYukseklik);

                int buttonX = (int)(centerX + Math.Cos(angle) * (panel1.Width / 3) - butonGenislik / 2);
                int buttonY = (int)(centerY + Math.Sin(angle) * (panel1.Height / 3 * panelAspect) - butonYukseklik / 2);



                buttonX -= butonGenislik / 4;
                buttonY -= butonYukseklik / 4;

                int cakismaDenemeSayisi = 0;




                while (ButonlarArasindaCakismaVarMi(oyuncuButton, oyuncuButonlari) ||
                       !ArasindaAralikVarMi(buttonX, buttonY, oyuncuButonlari))
                {
                    angle += angleIncrement / 10; // 10 kat daha küçük bir açý artýþý ile tekrar kontrol et
                    buttonX = (int)(centerX + Math.Cos(angle) * (panel1.Width / 3) - butonGenislik / 2);
                    buttonY = (int)(centerY + Math.Sin(angle) * (panel1.Height / 3 * panelAspect) - butonYukseklik / 2);
                    buttonX -= butonGenislik / 4;
                    buttonY -= butonYukseklik / 4;

                    // Çakýþma deneme sayýsý kontrolü ekleniyor
                    cakismaDenemeSayisi++;
                    if (cakismaDenemeSayisi >= oyuncuSayisi * 10)
                    {
                        // Belirli bir sayýda deneme sonunda çakýþma tespit edilemezse, hata mesajý ver ve iþlemi iptal et
                        MessageBox.Show("Butonlar arasýnda çakýþma tespit edilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                oyuncuButton.Location = new Point(buttonX, buttonY);
                oyuncuButonlari.Add(oyuncuButton);
                panel1.Controls.Add(oyuncuButton);
                angle += angleIncrement;
            }

            Task.Run(() =>
            {
                int index = 0;
                int tur = 1;

                while (oyuncular.Count > 1)
                {
                    var saldiran = oyuncular[index];
                    var hedefIndex = (index + 1) % oyuncular.Count;
                    var hedef = oyuncular[hedefIndex];

                    this.Invoke((Action)(() =>
                    {
                        // Her bir oyuncu saldýrýldýðýnda buton rengini deðiþtir
                        Button saldiranButton = oyuncuButonlari.Find(button => (int)button.Tag == saldiran.Numara);
                        Button hedefButton = oyuncuButonlari.Find(button => (int)button.Tag == hedef.Numara);

                        if (saldiranButton != null) { saldiranButton.BackColor = Color.Green; }
                        if (hedefButton != null) { hedefButton.BackColor = Color.Red; }

                        listBox1.Items.Insert(0, $"[{tur}. TUR] | {saldiran.Numara}. Oyuncu, {hedef.Numara}. Oyuncuyu vurdu.");

                        hedef.Vurul();
                        oyuncular.RemoveAll(oyuncu => !oyuncu.Canli);
                        index = oyuncular.IndexOf(saldiran) + 1;
                        index %= oyuncular.Count;
                        tur++;
                        turIndex.Text = tur.ToString();
                    }));

                    Thread.Sleep(100); // Her tur arasýnda bir saniye bekle
                }

                Oyuncu kazanan = oyuncular[0];

                this.Invoke((Action)(() =>
                {
                    listBox1.Items.Insert(0, $"[OYUN SONA ERDÝ] KAZANAN: {kazanan.Numara}");
                    winnerText.Visible = true;
                    winnerText.Text = kazanan.Numara.ToString();
                }));
            });
        }

        private bool ButonlarArasindaCakismaVarMi(Button yeniButon, List<Button> mevcutButonlar)
        {
            foreach (Button mevcutButon in mevcutButonlar)
            {
                if (yeniButon.Bounds.IntersectsWith(mevcutButon.Bounds))
                {
                    return true; // Çakýþma var
                }
            }
            return false; // Çakýþma yok
        }

        private bool ArasindaAralikVarMi(int x, int y, List<Button> mevcutButonlar)
        {
            foreach (Button mevcutButon in mevcutButonlar)
            {
                if (Math.Abs(x - mevcutButon.Location.X) < aralik && Math.Abs(y - mevcutButon.Location.Y) < aralik)
                {
                    return false; // Belirtilen aralýkta çakýþma var
                }
            }
            return true; // Belirtilen aralýkta çakýþma yok
        }
    }

    class Oyuncu
    {
        public int Numara { get; set; }
        public bool Canli { get; set; }
        public Oyuncu(int numara) { Numara = numara; Canli = true; }
        public void Vurul()
        {
            Canli = false;
        }
    }
}
