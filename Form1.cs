using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a = Convert.ToString("1881");
        string b = Convert.ToString("1882");
        string c = Convert.ToString("1884");
        string d = Convert.ToString("1880");
        string cevap = Convert.ToString("1881");
        int sure = 10;


        int dogru = 0, yanlis = 0, sorusayisi=1;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button5.Enabled = false;
            richTextBox1.Text = "Mustafa Kemal Atatürk kaç yılında doğmuştur?";

            button1.Text = a.ToString();
            button2.Text = b.ToString();
            button3.Text = c.ToString();
            button4.Text = d.ToString();
            dogru = Convert.ToInt32(label4.Text);
            yanlis = Convert.ToInt32(label5.Text);
            sorusayisi = Convert.ToInt32(label2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.BackColor = Color.Crimson;
            button5.Enabled = true;

            if (button2.Text == cevap)
            {
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();   
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.BackColor = Color.Crimson;

            button5.Enabled = true;

            if (button3.Text == cevap)
            {
                dogru++;
                label4.Text = dogru.ToString();
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sure = 10;
            label8.Text = sure.ToString();
            timer1.Enabled=true;
            sorusayisi++;
            label2.Text = sorusayisi.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            if (sorusayisi == 2)
            {
                cevap = "İstanbul";
                richTextBox1.Text = "Hangi İlimizin plakası 34tür?";
                button1.Text = "Ankara";
                button2.Text = "İzmir";
                button3.Text = "Antalya";
                button4.Text = "İstanbul";
                button1.BackColor = Color.PeachPuff;
                button2.BackColor = Color.PeachPuff;
                button3.BackColor = Color.PeachPuff;
                button4.BackColor = Color.PeachPuff;
            }
            if (sorusayisi == 3)
            {
                button5.Visible = false;
                cevap = "Ankara";
                richTextBox1.Text = "Türkiyenin Başkenti neresidir?";
                button1.Text = "Adana";
                button2.Text = "Amasya";
                button3.Text = "Ankara";
                button4.Text = "İstanbul";
                button1.BackColor = Color.PeachPuff;
                button2.BackColor = Color.PeachPuff;
                button3.BackColor = Color.PeachPuff;
                button4.BackColor = Color.PeachPuff;





            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(label8.Text);
            sure = sure - 1;
            label8.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Enabled= false;
                button1.Enabled= false;
                button2.Enabled= false;
                button3.Enabled= false;
                button4.Enabled= false;
                yanlis++;
                label5.Text= yanlis.ToString();
                button5.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button5.Enabled = true;
            button4.BackColor = Color.Crimson;



            if (button4.Text == cevap)
            {
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button5.Enabled = true;
            button1.BackColor = Color.Crimson;


            if (button1.Text == cevap)
            {
                dogru++;
                label4.Text=dogru.ToString();
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
    }
