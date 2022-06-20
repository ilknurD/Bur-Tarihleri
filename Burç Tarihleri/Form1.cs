using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burç_Tarihleri
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay, gün;
            ay = Convert.ToInt16(dateTimePicker1.Value.Month);
            gün = Convert.ToInt16(dateTimePicker1.Value.Day);

            if ((ay == 3 && gün >= 21) || (ay == 4 && gün <= 20))
                MessageBox.Show("Koç Burcusunuz");

            if ((ay == 4 && gün >= 21) || (ay == 5 && gün <= 21))
                MessageBox.Show("Boğa Burcusunuz");

            if ((ay == 5 && gün >= 22) || (ay == 6 && gün <= 22))
                MessageBox.Show("İkizler Burcusunuz");

            if ((ay == 6 && gün >= 23) || (ay == 7 && gün <= 22))
                MessageBox.Show("Yengeç Burcusunuz");

            if ((ay == 7 && gün >= 23) || (ay == 8 && gün <= 22))
                MessageBox.Show("Aslan Burcusunuz");

            if ((ay == 8 && gün >= 23) || (ay == 9 && gün <= 22))
                MessageBox.Show("Başak Burcusunuz");

            if ((ay == 9 && gün > 23) || (ay == 10 && gün <= 22))
                MessageBox.Show("Terazi Burcusunuz");

            if ((ay == 10 && gün > 23) || (ay == 11 && gün <= 21))
                MessageBox.Show("Akrep Burcusunuz");

            if ((ay == 11 && gün > 22) || (ay == 12 && gün <= 21))
                MessageBox.Show("Yay Burcusunuz");

            if ((ay == 12 && gün > 22) || (ay == 1 && gün <= 21))
                MessageBox.Show("Oğlak Burcusunuz");

            if ((ay == 1 && gün > 22) || (ay == 2 && gün <= 19))
                MessageBox.Show("Kova Burcusunuz");

            if ((ay == 2 && gün > 20) || (ay == 3 && gün <= 20))
                MessageBox.Show("Balık Burcusunuz");


        }
    }
}
