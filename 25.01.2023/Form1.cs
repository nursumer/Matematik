using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25._01._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //matematik1.DortIslem.Toplam(5, 2);
            //MessageBox.Show(matematik1.DortIslem.Toplam(5, 2).ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox1.Text);
            double sayi2 = double.Parse(textBox2.Text);
            string sonuc = comboBox1.Text;
            switch (sonuc)
            {
                case "Toplama":
                    double sonuc1 = matematik1.DortIslem.Toplam(sayi1, sayi2);
                    label4.Text = sonuc1.ToString();
                    break;
                case "Çıkarma":
                    double sonuc2 = matematik1.DortIslem.Cikarma(sayi1, sayi2);
                    label4.Text = sonuc2.ToString();
                    break;
                case "Çarpma":
                    double sonuc3 = matematik1.DortIslem.Carpma(sayi1, sayi2);
                    label4.Text = sonuc3.ToString();
                    break;
                case "Bölme":
                    double sonuc4 = matematik1.DortIslem.Bolme(sayi1, sayi2);
                    label4.Text = sonuc4.ToString();
                    break;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
