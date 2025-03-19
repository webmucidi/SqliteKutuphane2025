

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
            // SQLite ba�lant�s�n� olu�tur ve kutuphane.db dosyas�na ba�lan
            using (SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane.db;Version=3;"))
            {
                baglanti.Open(); // Ba�lant�y� a�

                // Kitap ekleme SQL sorgusunu haz�rla
                string sorgu = "INSERT INTO Kitaplar (KitapAdi, Yazar, Yayinevi, SayfaSayisi) VALUES (@kitapAdi, @yazar, @yayinevi, @sayfaSayisi)";

                // Sorguyu �al��t�rmak i�in SQLite komut nesnesini olu�tur
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);

                // Kullan�c�n�n girdi�i de�erleri sorgudaki parametrelere ekle
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfaSayisi", txtSayfaSayisi.Text);

                komut.ExecuteNonQuery(); // Sorguyu �al��t�r ve kitab� veritaban�na ekle

                MessageBox.Show("Kitap ba�ar�yla eklendi!"); // Kullan�c�ya bilgi mesaj� g�ster
            }

            KitaplariListele(); // Kitaplar� g�ncelle ve eklenen kitab� g�ster
        }
        private void KitaplariListele()
        {
            // SQLite ba�lant�s�n� olu�tur ve kutuphane.db dosyas�na ba�lan
            using (SQLiteConnection baglanti = new SQLiteConnection("Data Source=kutuphane.db;Version=3;"))
            {
                baglanti.Open(); // Ba�lant�y� a�

                // Kitaplar� listeleme SQL sorgusunu haz�rla
                string sorgu = "SELECT * FROM Kitaplar";

                // SQLiteDataAdapter kullanarak verileri �ek ve DataTable'a doldur
                SQLiteDataAdapter adaptor = new SQLiteDataAdapter(sorgu, baglanti);
                System.Data.DataTable tablo = new System.Data.DataTable();
                adaptor.Fill(tablo); // Verileri DataTable'a y�kle

                dgvKitaplar.DataSource = tablo; // DataGridView�e verileri ekleyerek ekranda g�ster
            }
        }


    }
}
