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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Futbolcuİslem_Click(object sender, EventArgs e)
        {
            Futbolcuislemleri futbolcuislemleri=new Futbolcuislemleri();
            futbolcuislemleri.Show();
            this.Hide();
        }

        private void btn_Takimİslem_Click(object sender, EventArgs e)
        {
            Takimİslemleri takimislemleri=new Takimİslemleri();
            takimislemleri.Show();
            this.Hide();
        }
    }
}
