using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace VarmısınYokmusun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList paralar = new ArrayList();
        ArrayList teklif = new ArrayList();
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            button25.Visible = false;
            label26.Visible = false;
            paralar.Add("1");
            paralar.Add("2");
            paralar.Add("5");
            paralar.Add("10");
            paralar.Add("25");
            paralar.Add("50");
            paralar.Add("100");
            paralar.Add("200");
            paralar.Add("300");
            paralar.Add("400");
            paralar.Add("500");
            paralar.Add("750");
            paralar.Add("10000");
            paralar.Add("20000");
            paralar.Add("30000");
            paralar.Add("40000");
            paralar.Add("50000");
            paralar.Add("100000");
            paralar.Add("125000");
            paralar.Add("150000");
            paralar.Add("200000");
            paralar.Add("500000");
            paralar.Add("500000");
            paralar.Add("500000");
            teklif.Add("1");
            teklif.Add("2");
            teklif.Add("5");
            teklif.Add("10");
            teklif.Add("25");
            teklif.Add("50");
            teklif.Add("100");
            teklif.Add("200");
            teklif.Add("300");
            teklif.Add("400");
            teklif.Add("500");
            teklif.Add("750");
            teklif.Add("10000");
            teklif.Add("20000");
            teklif.Add("30000");
            teklif.Add("40000");
            teklif.Add("50000");
            teklif.Add("100000");
            teklif.Add("125000");
            teklif.Add("150000");
            teklif.Add("200000");
            teklif.Add("500000");
            teklif.Add("500000");
            teklif.Add("500000");
            int x = rnd.Next(0, paralar.Count);
            button1.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button2.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button3.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button4.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button5.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button6.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button7.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button8.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button9.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button10.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button11.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button12.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button13.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button14.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button15.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button16.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button17.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button18.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button19.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button20.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button21.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button22.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button23.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);
            x = rnd.Next(0, paralar.Count);
            button24.Text = paralar[x].ToString();
            paralar.Remove(paralar[x]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button25.Text == "")
            {
                button25.Text = button1.Text;
                button25.Visible = true;
                button1.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button1.Text;
                button1.Visible = false;
                kontrol();
                
            }
        }
        int toplam = 0;
        private void kontrol()
        {
            if (label28.Text == label2.Text)
            {
                label2.Visible = false;

            }
            else if (label28.Text == label3.Text)
            {
                label3.Visible = false;
            }
            else if (label28.Text == label4.Text)
            {
                label4.Visible = false;
            }
            else if (label28.Text == label5.Text)
            {
                label5.Visible = false;
            }
            else if (label28.Text == label6.Text)
            {
                label6.Visible = false;
            }
            else if (label28.Text == label7.Text)
            {
                label7.Visible = false;
            }
            else if (label28.Text == label8.Text)
            {
                label8.Visible = false;
            }
            else if (label28.Text == label9.Text)
            {
                label9.Visible = false;
            }
            else if (label28.Text == label10.Text)
            {
                label10.Visible = false;
            }
            else if (label28.Text == label11.Text)
            {
                label11.Visible = false;
            }
            else if (label28.Text == label12.Text)
            {
                label12.Visible = false;
            }
            else if (label28.Text == label13.Text)
            {
                label13.Visible = false;
            }
            else if (label28.Text == label14.Text)
            {
                label14.Visible = false;
            }
            else if (label28.Text == label15.Text)
            {
                label15.Visible = false;
            }
            else if (label28.Text == label16.Text)
            {
                label16.Visible = false;
            }
            else if (label28.Text == label17.Text)
            {
                label17.Visible = false;
            }
            else if (label28.Text == label18.Text)
            {
                label18.Visible = false;
            }
            else if (label28.Text == label19.Text)
            {
                label19.Visible = false;
            }
            else if (label28.Text == label20.Text)
            {
                label20.Visible = false;
            }
            else if (label28.Text == label21.Text)
            {
                label21.Visible = false;
            }
            else if (label28.Text == label22.Text)
            {
                label22.Visible = false;
            }
            else if (label28.Text == label23.Text && label23.Visible != false)
            {
                label23.Visible = false;
            }
            else if (label28.Text == label24.Text && label24.Visible != false)
            {
                label24.Visible = false;
            }
            else if (label28.Text == label25.Text && label25.Visible != false)
            {
                label25.Visible = false;
            }
            teklif.Remove(label28.Text);
            label30.Text = (Convert.ToInt16(label30.Text) - 1).ToString();//label30 da teklife kaç el kaldığı hesaplandı.
            if (label30.Text == "0")//label30 0 a eşit olduğu zaman teklif zamanı demektir. Burda kontrol edildi.
            {
                for (int i = 0; i < teklif.Count; i++)//elimizde kalan paralar toplanıp kutu sayısına bölünerek teklife yakın ve mantıklı sonuçlar hesaplanı.
                {
                    toplam = toplam + Convert.ToInt32(teklif[i]);
                }
                toplam = toplam / teklif.Count;
                toplam = toplam / 2;
                prgresBar();
                DialogResult sonuc = MessageBox.Show("Hamdi Beyin Teklifi = "+toplam+" Kabul Ediyormusunuz ?", "Teklif!", MessageBoxButtons.OKCancel);
                if (sonuc == DialogResult.OK)
                {
                    MessageBox.Show("Tebrikler "+toplam+"TL Kazandınız..");
                    Application.Exit();
                }
                else
                {
                    if (teklif.Count == 2)
                    {
                        sonuc = MessageBox.Show("Kutuya Gitmek İstermisiniz ?", "Teklif", MessageBoxButtons.YesNo);
                        if (sonuc == DialogResult.Yes)
                        {
                            prgresBar();
                            MessageBox.Show("Tebrikler " + button25.Text + "TL Kazandınız..");
                            Application.Exit();
                        }
                        else
                        {
                            prgresBar();
                            teklif.Remove(button25.Text);
                            MessageBox.Show("Tebrikler " +teklif[0] + "TL Kazandınız..");
                            Application.Exit();
                        }
                    }
                    else if (teklif.Count <= 4)
                    {
                        label30.Text = "1";
                    }
                    else
                    {
                        label30.Text = "3";
                    }
                    label28.Text = "";
                    toplam = 0;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (button25.Text == "")
            {
                button25.Text = button2.Text;
                button25.Visible = true;
                button2.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button2.Text;
                button2.Visible = false;
                kontrol();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (button25.Text == "")
            {
                button25.Text = button3.Text;
                button25.Visible = true;
                button3.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button3.Text;
                button3.Visible = false;
                kontrol();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (button25.Text == "")
            {
                button25.Text = button4.Text;
                button25.Visible = true;
                button4.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button4.Text;
                button4.Visible = false;
                kontrol();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button5.Text;
                button25.Visible = true;
                button5.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button5.Text;
                button5.Visible = false;
                kontrol();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button6.Text;
                button25.Visible = true;
                button6.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button6.Text;
                button6.Visible = false;
                kontrol();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button12.Text;
                button25.Visible = true;
                button12.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button12.Text;
                button12.Visible = false;
                kontrol();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button11.Text;
                button25.Visible = true;
                button11.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button11.Text;
                button11.Visible = false;
                kontrol();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button10.Text;
                button25.Visible = true;
                button10.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button10.Text;
                button10.Visible = false;
                kontrol();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button9.Text;
                button25.Visible = true;
                button9.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button9.Text;
                button9.Visible = false;
                kontrol();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button8.Text;
                button25.Visible = true;
                button8.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button8.Text;
                button8.Visible = false;
                kontrol();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button7.Text;
                button25.Visible = true;
                button7.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button7.Text;
                button7.Visible = false;
                kontrol();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button13.Text;
                button25.Visible = true;
                button13.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button13.Text;
                button13.Visible = false;
                kontrol();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button14.Text;
                button25.Visible = true;
                button14.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button14.Text;
                button14.Visible = false;
                kontrol();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button15.Text;
                button25.Visible = true;
                button15.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button15.Text;
                button15.Visible = false;
                kontrol();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button16.Text;
                button25.Visible = true;
                button16.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button16.Text;
                button16.Visible = false;
                kontrol();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button17.Text;
                button25.Visible = true;
                button17.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button17.Text;
                button17.Visible = false;
                kontrol();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button18.Text;
                button25.Visible = true;
                button18.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button18.Text;
                button18.Visible = false;
                kontrol();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button19.Text;
                button25.Visible = true;
                button19.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button19.Text;
                button19.Visible = false;
                kontrol();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button20.Text;
                button25.Visible = true;
                button20.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button20.Text;
                button20.Visible = false;
                kontrol();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button21.Text;
                button25.Visible = true;
                button21.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button21.Text;
                button21.Visible = false;
                kontrol();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button22.Text;
                button25.Visible = true;
                button22.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button22.Text;
                button22.Visible = false;
                kontrol();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button23.Text;
                button25.Visible = true;
                button23.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button23.Text;
                button23.Visible = false;
                kontrol();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button25.Text == "")
            {
                button25.Text = button24.Text;
                button25.Visible = true;
                button24.Visible = false;
                label26.Visible = true;
                label1.Visible = false;
            }
            else
            {
                prgresBar();
                label28.Text = button24.Text;
                button24.Visible = false;
                kontrol();
            }
        }
        private void prgresBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                for (int a = 0; a < 9999999; a++) ;
                progressBar1.Value = i;
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
