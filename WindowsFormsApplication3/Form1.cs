using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Vize1, Vize2, Final, Ortalama;
            Vize1 = Convert.ToDouble(textBox1.Text);
            Vize2 = Convert.ToDouble(textBox2.Text);
            Final = Convert.ToDouble(textBox3.Text);
            Ortalama = Vize1 * 30 / 100 + Vize2 * 30 / 100 + Final * 40 / 100;

            if (Ortalama <= 49)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:FF"));
            }
            else if (Ortalama > 50 && Ortalama < 59)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:DD"));
            }
            else if (Ortalama > 60 && Ortalama < 64)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:DC"));
            }
            else if (Ortalama > 65 && Ortalama < 74)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:CC"));
            }
            else if (Ortalama > 75 && Ortalama < 79)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:CB"));
            }
            else if (Ortalama > 80 && Ortalama < 84)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:BB"));
            }
            else if (Ortalama > 85 && Ortalama < 89)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:BA"));
            }
            else if (Ortalama > 90 && Ortalama < 100)
            {
                MessageBox.Show(("Ortalama:") + Ortalama.ToString() + ("Harf Notu:AA"));
            }

            else if (Vize1<0 || Vize1>100 || Vize2<0 || Vize2>100 || Final<0 || Final>100)
            {
                MessageBox.Show("Sınav değeri 0-100 arasında olmalı");
            }
        
          


        }
    }
}





