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

namespace imageView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] resimler;
        int i;
        int hangiresim = 0;
        int gec = 0;
        int button1 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            resimler = Directory.GetFiles("../../images","*.jpg");
            foreach (string item in resimler)
            {
                Button btn = new Button();
                btn.Width = btn.Height = 68;
                btn.Padding = new Padding(0);
                btn.BackgroundImage = Image.FromFile(item);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Tag = i++;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_click;
                   
            }

            

            
        }
        void btn_click(object sender, EventArgs e)
        {
            Button basilan = sender as Button;
            pictureBox1.Image = Image.FromFile(resimler[Convert.ToInt32(basilan.Tag)]);
        }

        private void btn_ilk_Click(object sender, EventArgs e)
        {
            hangiresim = 0;
            pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

            
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            hangiresim++;
            if (hangiresim>resimler.Length-1)
            {
                hangiresim = 0;
            }
            pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

        }

        private void btn_son_Click(object sender, EventArgs e)
        {
            hangiresim = resimler.Length-1;
            pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pictureBox1.Image = Image.FromFile(resimler[rnd.Next(0, resimler.Length)]);

        }

        private void btn_slayt_Click(object sender, EventArgs e)
        {
            
            button1++;
            timer1.Start();
            btn_slayt.Text = "durdur";
            if (button1==2)
            {
                btn_slayt.Text="Slayt";
                timer1.Stop();
                button1 = 0;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gec++;
            if (hangiresim > resimler.Length - 1)
            {
                hangiresim = 0;
            }
            pictureBox1.Image = Image.FromFile(resimler[hangiresim++]);

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (hangiresim ==0)
            {
                hangiresim = resimler.Length-1;
            }
            else
            {
                hangiresim--;
            }
            pictureBox1.Image = Image.FromFile(resimler[hangiresim]);

        }
    }
}
