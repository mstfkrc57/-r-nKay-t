using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211216_OOP_Urun_Girisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        urunler urunCek = new urunler();
        void urunleriListeleyelim()
        {
            if (combo_listele.SelectedIndex == 1)
            {
                urunleriListele();
            }
            
        }
        void urunleriListele()
        {
            urunCek.urunAdi = txt_ad.Text;
            listele.Items.Add(urunCek.urunAdi);
            urunCek.urunTipi = txt_tip.Text;
            listele.Items.Add(urunCek.urunTipi);
            urunCek.urunDesi =Convert.ToInt32(txt_desi.Text);
            listele.Items.Add(urunCek.urunDesi);
            urunCek.urunModel = txt_model.Text;
            listele.Items.Add(urunCek.urunModel);
            urunCek.urunRengi = txt_renk.Text;
            listele.Items.Add(urunCek.urunRengi);
            urunCek.urunMarka = txt_marka.Text;
            listele.Items.Add(urunCek.urunMarka);

        }
        void temizle()
        {
            listele.Items.Clear();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunleriListele();
           
        }

        private void combo_listele_SelectedIndexChanged(object sender, EventArgs e)
        {
            urunleriListeleyelim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            combo_listele.Items.Add(urunCek.urunAdi);
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
