﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int second = 21; // 21 çünkü 21 -- gideceği için 20 den geriye sayacak (20 yapsan 19 dan saymaya başlar :)))
        static int sonuc;
        static int puan;
        static string method;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }


        public void Randomizer()
        {
            try
            {
                timer1.Start();
                textBox1.Enabled = true;


                int sayi1 = new Random().Next(1, 200);
                int sayi2 = new Random().Next(1, 100);

                label7.Text = sayi1.ToString();
                label8.Text = sayi2.ToString();

                // Puan
                label2.Text = "Puan : " + puan.ToString();

                // İşlem

                checkİslem(sayi1, sayi2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkİslem(int sayi1, int sayi2)
        {
            if (sayi1 < 200 && sayi1 > 150)
            {
                method = "Toplama";
                int toplam = Convert.ToInt32(sayi1 + sayi2);
                sonuc = toplam;
            }
            else if (sayi1 < 150 && sayi1 > 50)
            {
                method = "Çıkarma";
                int cikarma = Convert.ToInt32(sayi1 - sayi2);
                sonuc = cikarma;
            }
            else if (sayi1 < 50 && sayi1 > 20)
            {
                method = "Çarpma";
                int carpma = Convert.ToInt32(sayi1 * sayi2);
                sonuc = carpma;
            }
            else if (sayi1 < 20 && sayi1 > 1)
            {
                method = "Bölme";
                int bolme = Convert.ToInt32(sayi1 / sayi2);
                sonuc = bolme;
            }
            label6.Text = method;
            timer2.Start();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Randomizer();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int islem = Convert.ToInt32(textBox1.Text);
                if (method == "Toplama")
                {
                    if (sonuc == islem)
                    {
                        puan += 10;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Green;
                        label10.Text = "Doğru";
                        Randomizer();
                        second += 10;

                    }
                    else
                    {
                        puan -= 5;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Red;
                        label10.Text = "yanlış";
                    }
                }
                else if (method == "Çıkarma")
                {
                    if (sonuc == islem)
                    {
                        puan += 10;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Green;
                        label10.Text = "Doğru";
                        Randomizer();
                        second += 10;
                    }
                    else
                    {
                        puan -= 5;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Red;
                        label10.Text = "yanlış";
                    }
                }
                else if (method == "Çarpma")
                {
                    if (sonuc == islem)
                    {
                        puan += 10;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Green;
                        label10.Text = "Doğru";
                        Randomizer();
                        second += 10;
                    }
                    else
                    {
                        puan -= 5;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Red;
                        label10.Text = "yanlış";
                    }
                }
                else if (method == "Bölme")
                {
                    if (sonuc == islem)
                    {
                        puan += 10;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Green;
                        label10.Text = "Doğru";
                        Randomizer();
                        second += 10;
                    }
                    else
                    {
                        puan -= 5;
                        label2.Text = "Puan: " + puan.ToString();
                        label10.ForeColor = Color.Red;
                        label10.Text = "yanlış";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // tick = intval için geçen süre (1.000 = 1 saniye de 1 kez) 100 = 1 milisaniye de 1 kez gibi
        {
            if (timer1.Enabled) // timer aktifse
            {
                second--; // 21 den azaltarak ilerle (timer 1 saniye de 1 oto azaltıcak)
                lblSecond.Text = Convert.ToString(second); // convert method
                if (second == 0) // süre biter
                {
                    timer1.Stop(); // timer dur
                    lblSecond.Text = "0"; // label text i 0 yap
                    puan = 0;
                    MessageBox.Show("SÜRE BİTTİ!"); // log verdir vb
                    second = 21;
                    // EASY PEASY :D
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label10.Text = string.Empty;
            timer2.Stop();
        }
    }
}
