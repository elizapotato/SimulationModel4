using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        const double k = 0.5;
        int days = -1;
        double rub = 1000;
        int lary = 0;
        double rate = 22.69;
        Random rand = new Random();

        private void startB_Click(object sender, EventArgs e)
        {          
            days++;
            rate = rate * (1 + k * (rand.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(days, rate);
            labDays.Text = "День: " + days;
            labRate.Text = "Курс:" + rate;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butBuy_Click(object sender, EventArgs e)
        {
            lary += (int)boxLary.Value;
            labLary.Text = "Грузинские\nлари: " + lary;
            rub -= rate * (int)boxLary.Value;
            labRub.Text = "Рублей: " + rub;
            if (rub < 0)
            {
                MessageBox.Show("Вы проиграли!");
                this.Close();
            }
        }

        private void butSell_Click(object sender, EventArgs e)
        {
            if (lary < (int)boxLary.Value) MessageBox.Show("Недостаточно валюты!");
            else
            { 
                lary -= (int)boxLary.Value;
                labLary.Text = "Грузинские\nлари: " + lary;
                rub += rate * (int)boxLary.Value;
                labRub.Text = "Рублей: " + rub;
            }
        }
    }
}
