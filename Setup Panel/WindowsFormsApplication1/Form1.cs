using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            label1.Text = "%" + progressBar1.Value + " Tamamlandı!";
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (progressBar1.Value == 100)
                {

                }
                progressBar1.Value += progressBar1.Step;
                label1.Text = "%" + progressBar1.Value + " Tamamlandı!";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata! Maksimum değerden büyük olamaz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (progressBar1.Value == 0)
                {

                }
                progressBar1.Value -= progressBar1.Step;
                label1.Text = "%" + progressBar1.Value + " Tamamlandı!";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata! Minimum değerden küçük olamaz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
                label1.Text = "%" + progressBar1.Value + " Tamamlandı!";
            }
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 100;
                label1.Text = "%" + progressBar1.Value + " Tamamlandı!";
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("İşlem Bitti");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 0)
            {
                progressBar1.Value--;
                label1.Text = "%" + progressBar1.Value + " Tamamlandı!";
            }
            if (progressBar1.Value == 0)
            {
                progressBar1.Value = 0;
                label1.Text = "%" + progressBar1.Value + " Tamamlandı!";
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("İşlem Bitti");
            }
        }
    }
    }
