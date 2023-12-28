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
    public partial class Takimİslemleri : Form
    {
        public Takimİslemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje;" +
            " user Id=postgres; password=Canorge54");
        private void btn_takimyazdir_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from takim";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Takimİslemleri_Load(object sender, EventArgs e)
        {
           NpgsqlDataAdapter da=new NpgsqlDataAdapter("select* from stadyum",baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "stadyum_ad";
            comboBox1.ValueMember = "stadyum_id";
            comboBox1.DataSource = dt;

            NpgsqlDataAdapter Nda=new NpgsqlDataAdapter("select* from lig",baglanti);
            DataTable dt2=new DataTable();
            Nda.Fill(dt2);
            comboBox2.DisplayMember = "lig_adi";
            comboBox2.ValueMember = "lig_id";
            comboBox2.DataSource = dt2;
        }

        private void btn_takimekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ekle = new NpgsqlCommand("insert into takim values(@v1,@v2,@v3,@v4)", baglanti);
            ekle.Parameters.AddWithValue("@v1",int.Parse(txt_takimid.Text));
            ekle.Parameters.AddWithValue("@v2",txt_takimad.Text);
            ekle.Parameters.AddWithValue("@v3", comboBox1.SelectedValue);
            ekle.Parameters.AddWithValue("@v4", comboBox2.SelectedValue);
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btntakimsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from takim where takim_id=@v1 and takim_ad=@v2" +
                " and stadyum_id=@v3 and lig_id=@v4", baglanti);
            sil.Parameters.AddWithValue("@v1", int.Parse(txt_takimid.Text));
            sil.Parameters.AddWithValue("@v2", txt_takimad.Text);
            sil.Parameters.AddWithValue("@v3", comboBox1.SelectedValue);
            sil.Parameters.AddWithValue("@v4", comboBox2.SelectedValue);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_takimguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand guncelle = new NpgsqlCommand("update takim set takim_ad=@v1," +
                "stadyum_id=@v2,lig_id=@v3 where takim_id=@v4", baglanti);
            guncelle.Parameters.AddWithValue("@v1", txt_takimad.Text);
            guncelle.Parameters.AddWithValue("@v2", comboBox1.SelectedValue);
            guncelle.Parameters.AddWithValue("@v3", comboBox2.SelectedValue);
            guncelle.Parameters.AddWithValue("@v4",int.Parse(txt_takimid.Text));
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_takimara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = int.Parse(txt_takimid.Text);

            NpgsqlCommand ara = new NpgsqlCommand("select* from takimbul(@v1)", baglanti);
            ara.Parameters.AddWithValue("@v1", id);
            DataTable dt = new DataTable();
            var result = ara.ExecuteReader();
            dt.Load(result);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btn_menuyegel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
