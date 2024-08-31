using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sifreli_Veriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KIMUOA0\SQLEXPRESS;Initial Catalog=DbSifreleme;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblVeriler", baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        void temizle()
        {
            textBoxAD.Text = "";
            textBoxSOYAD.Text = "";
            textBoxMAIL.Text = "";
            textBoxSIFRE.Text = "";
            textBoxHESAPNO.Text = "";
            textBoxAD.Focus();

        }
        private void buttonKAYDET_Click(object sender, EventArgs e)
        {
           
                //ad
                string ad = textBoxAD.Text;
                byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
                string adsifre = Convert.ToBase64String(addizi);

                //soyad
                string soyad = textBoxSOYAD.Text;
                byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
                string soyadsifre = Convert.ToBase64String(soyaddizi);

                //mail
                string mail = textBoxMAIL.Text;
                byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
                string mailsifre = Convert.ToBase64String(maildizi);

                //sifre
                string sifre = textBoxSIFRE.Text; // Düzeltme: soyad yerine sifre kullanılmalı
                byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
                string passwordsifre = Convert.ToBase64String(sifredizi);

                //hesapNo
                string hesapno = textBoxHESAPNO.Text;
                byte[] hesapnodizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
                string hesapnosifre = Convert.ToBase64String(hesapnodizi);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblVeriler (AD, SOYAD, MAIL, SIFRE, HESAPNO) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", adsifre); // Şifrelenmiş veri
                komut.Parameters.AddWithValue("@p2", soyadsifre); // Şifrelenmiş veri
                komut.Parameters.AddWithValue("@p3", mailsifre); // Şifrelenmiş veri
                komut.Parameters.AddWithValue("@p4", passwordsifre); // Şifrelenmiş veri
                komut.Parameters.AddWithValue("@p5", hesapnosifre); // Şifrelenmiş veri
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veriler başarılı bir şekilde eklendi ve şifrelendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void buttonSIFRECOZ_Click(object sender, EventArgs e)
        {
            //ad dounusum
            string adcozum=textBoxAD.Text;
            byte[] adcozumdizi=Convert.FromBase64String(adcozum);   
            string adveri=ASCIIEncoding.ASCII.GetString(adcozumdizi);
            label6.Text = adveri;

            //soyad dounusum
            string soyadcozum = textBoxAD.Text;
            byte[] soyadcozumdizi = Convert.FromBase64String(soyadcozum);
            string soyadveri = ASCIIEncoding.ASCII.GetString(soyadcozumdizi);
            label6.Text = soyadveri;

            //mail dounusum
            string mailcozum = textBoxAD.Text;
            byte[] mailcozumdizi = Convert.FromBase64String(mailcozum);
            string mailveri = ASCIIEncoding.ASCII.GetString(mailcozumdizi);
            label6.Text = mailveri;

            //sifre donusum
            string sifrecozum = textBoxAD.Text;
            byte[] sifrecozumdizi = Convert.FromBase64String(sifrecozum);
            string sifreveri = ASCIIEncoding.ASCII.GetString(sifrecozumdizi);
            label6.Text = sifreveri;

            //hesapNo donusum
            string hesapnocozum = textBoxAD.Text;
            byte[] hesapnocozumdizi = Convert.FromBase64String(hesapnocozum);
            string hesapnoveri = ASCIIEncoding.ASCII.GetString(hesapnocozumdizi);
            label6.Text = hesapnoveri;
        }
    }
}
