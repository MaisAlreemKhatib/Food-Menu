using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Yemek_Menusu
{
    public partial class Form1 : Form
    {
        private Menu menu;
        public Form1()
        {
            InitializeComponent();
            menu = new Menu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Meyve");
            comboBox1.Items.Add("Salata");
            comboBox1.Items.Add("Tatlı");
            comboBox1.Items.Add("İçecek");
        }




        private void TextBoxlariTemizle()
        {
            txtAdi.Clear();
            txtCins.Clear();
            txtFiyat.Clear();
            txtKdv.Clear();
            txtKalori.Clear();
            comboBox1.SelectedIndex = -1; // ComboBox'ı da sıfırla
        }


        private void ToplamFiyatHesapla()
        {
            double toplam = 0;

            foreach (var item in menu.menuYazdir())
            {
                toplam += item.fiyat;
            }

            txtToplamFiyat.Text = toplam.ToString("C2", new CultureInfo("tr-TR")); // Para birimi formatında göster
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string adi = txtAdi.Text;
                string cins = txtCins.Text;
                double fiyat = double.Parse(txtFiyat.Text);
                double kdv = double.Parse(txtKdv.Text);
                double kalori = double.Parse(txtKalori.Text);
                string tur = comboBox1.Text; // Seçilen tür

                // **Fiyat ve Kalori Kontrolü**
                if (fiyat < 50 || fiyat > 200 || kalori < 100 || kalori > 400)
                {
                    MessageBox.Show("Lütfen fiyatı 50-200 TL ve kaloriyi 100-400 arasında giriniz!", "Geçersiz Değer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Yiyecek? s = null;

                switch (tur)
                {
                    case "Meyve":
                        s = new Meyve(adi, cins, fiyat, kdv, kalori);
                        break;
                    case "Salata":
                        s = new Salata(adi, cins, fiyat, kdv, kalori);
                        break;
                    case "Tatlı":
                        s = new Tatli(adi, cins, fiyat, kdv, kalori);
                        break;
                    case "İçecek":
                        s = new Icecek(adi, cins, fiyat, kdv, kalori);
                        break;
                    default:
                        MessageBox.Show("Lütfen bir yiyecek türü seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (s != null)
                {
                    menu.ekle(s);

                    // **ListBox'a bilgileri ekleme (Tür en sonda)**
                    listBox1.Items.Add($"{s.yazdir()} - {tur}");

                    ToplamFiyatHesapla();
                    TextBoxlariTemizle();
                    MessageBox.Show("Ürün başarıyla menüye eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tüm alanlara geçerli sayısal değerler giriniz!", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Bilinmeyen Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliIndex = listBox1.SelectedIndex;
            if (seciliIndex != -1)
            {
                menu.sil(seciliIndex);
                listBox1.Items.RemoveAt(seciliIndex);
                ToplamFiyatHesapla(); // Toplam fiyatı güncelle

            }
        }

    }
}
