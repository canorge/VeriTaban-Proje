using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTProje
{
    public partial class Futbolcuislemleri : Form
    {
       
        
        public Futbolcuislemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti=new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje;" +
            " user Id=postgres; password=Canorge54");
        private void btn_futbolcuyazdir_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kisi inner join futbolcu on kisi.kisi_id=futbolcu.kisi_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
        }

        private void Futbolcuislemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            //futbolcu formunda takım seçme için combobaxa veritabanında veri çekme
            NpgsqlDataAdapter da=new NpgsqlDataAdapter("select * from takim",baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "takim_ad";
            comboBox1.ValueMember = "takim_id";
            comboBox1.DataSource = dt;

            //futbolcu formunda mevki seçme için combobaxa veritabanında veri çekme
            NpgsqlDataAdapter Da = new NpgsqlDataAdapter("select* from mevki",baglanti);
            DataTable Dta = new DataTable();
            Da.Fill(Dta);
            comboBox2.DisplayMember = "mevki_ad";
            comboBox2.ValueMember = "mevki_id";
            comboBox2.DataSource = Dta;

            baglanti.Close();

        }

        private void btn_futbolcuekle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            NpgsqlCommand eklekisi = new NpgsqlCommand("insert into kisi(kisi_id,kisi_ad,kisi_soyad) values(@v1,@v2,@v3)",baglanti);
            NpgsqlCommand eklefutbolcu = new NpgsqlCommand("insert into futbolcu(kisi_id,takim_id,mevki_id) values(@v1,@v4,@v5)",baglanti);
            eklekisi.Parameters.AddWithValue("@v1",int.Parse(txt_futbolcuid.Text));
            eklekisi.Parameters.AddWithValue("@v2",txt_futbolcuad.Text);
            eklekisi.Parameters.AddWithValue("@v3",txt_futbolcusoyad.Text);
            eklefutbolcu.Parameters.AddWithValue("@v1", int.Parse(txt_futbolcuid.Text));
            eklefutbolcu.Parameters.AddWithValue("@v4", comboBox1.SelectedValue);
            eklefutbolcu.Parameters.AddWithValue("@v5", comboBox2.SelectedValue);
            
            eklekisi.ExecuteNonQuery();
            eklefutbolcu.ExecuteNonQuery();
            baglanti.Close();
         
        }

        private void btn_futbolcusil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from futbolcu where kisi_id=@v1 and takim_id=@v2 and mevki_id=@v3", baglanti);
            NpgsqlCommand silkisi = new NpgsqlCommand("delete from kisi where kisi_id=@v1 ", baglanti);
            sil.Parameters.AddWithValue("@v1", int.Parse(txt_futbolcuid.Text));
            sil.Parameters.AddWithValue("@v2", comboBox1.SelectedValue);
            sil.Parameters.AddWithValue("@v3", comboBox2.SelectedValue);
            silkisi.Parameters.AddWithValue("@v1", int.Parse(txt_futbolcuid.Text));
            sil.ExecuteNonQuery();
            silkisi.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand guncelle = new NpgsqlCommand("update futbolcu set takim_id=@v1,mevki_id=@v2 where kisi_id=@v3", baglanti);
            guncelle.Parameters.AddWithValue("@v1", comboBox1.SelectedValue);
            guncelle.Parameters.AddWithValue("@v2", comboBox2.SelectedValue);
            guncelle.Parameters.AddWithValue("@v3", int.Parse(txt_futbolcuid.Text));
            guncelle.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = int.Parse(txt_futbolcuid.Text);

            NpgsqlCommand ara = new NpgsqlCommand("select* from kisibul(@v1)", baglanti);
            ara.Parameters.AddWithValue("@v1", id);
            DataTable dt=new DataTable();
            var result = ara.ExecuteReader();
            dt.Load(result);
            dataGridView1.DataSource =dt ;
            baglanti.Close();
        }
    }
}
