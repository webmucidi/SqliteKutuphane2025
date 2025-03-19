

namespace KutuphaneSinav2025
{
    using System.Data;
    using System.Data.SQLite; 
    using System.Windows.Forms;
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // SQLite baðlantýsýný oluþtur ve kutuphane.db dosyasýna baðlan
            using (SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane.db;Version=3;"))
            {
                baglanti.Open(); // Baðlantýyý aç

                // Kitap ekleme SQL sorgusunu hazýrla
                string sorgu = "INSERT INTO Kitaplar (KitapAdi, Yazar, Yayinevi, SayfaSayisi) VALUES (@kitapAdi, @yazar, @yayinevi, @sayfaSayisi)";

                // Sorguyu çalýþtýrmak için SQLite komut nesnesini oluþtur
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);

                // Kullanýcýnýn girdiði deðerleri sorgudaki parametrelere ekle
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfaSayisi", txtSayfaSayisi.Text);

                komut.ExecuteNonQuery(); // Sorguyu çalýþtýr ve kitabý veritabanýna ekle

                MessageBox.Show("Kitap baþarýyla eklendi!"); // Kullanýcýya bilgi mesajý göster
            }

            KitaplariListele(); // Kitaplarý güncelle ve eklenen kitabý göster
        }
        private void KitaplariListele()
        {
            // SQLite baðlantýsýný oluþtur ve kutuphane.db dosyasýna baðlan
            using (SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane.db;Version=3;"))
            {
                baglanti.Open(); // Baðlantýyý aç

                // Kitaplarý listeleme SQL sorgusunu hazýrla
                string sorgu = "SELECT * FROM Kitaplar";

                // SQLiteDataAdapter kullanarak verileri çek ve DataTable'a doldur
                SQLiteDataAdapter adaptor = new SQLiteDataAdapter(sorgu, baglanti);
                System.Data.DataTable tablo = new System.Data.DataTable();
                adaptor.Fill(tablo); // Verileri DataTable'a yükle

                dgvKitaplar.DataSource = tablo; // DataGridView’e verileri ekleyerek ekranda göster
            }
        }


    }
}
