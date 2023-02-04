using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Label bakuLbl = new Label();
        Label bakuDate = new Label();
        Label londonLbl = new Label();
        Label londonDate = new Label();
        Timer mytimer = new Timer();
        Timer londonTimer = new Timer();
        Timer bakuTimer = new Timer();
        System.Media.SoundPlayer bakuBackground=new System.Media.SoundPlayer(Properties.Resources.Vagif_Mustafazade___Baki_gecalari);
        System.Media.SoundPlayer londonBackground=new System.Media.SoundPlayer(Properties.Resources.Ralph_McTell_Streets_of_London);
        public Form1()
        {
            InitializeComponent();
            bakuBackground.Play();
            mytimer.Interval = 1000;
            mytimer.Tick += Mytimer_Tick;
            mytimer.Start();
        }
        public void Play(string audioPath)
        {
            var p1 = new System.Windows.Media.MediaPlayer();
            p1.Open(new System.Uri(audioPath));
            p1.Play();
        }
       
        private void Mytimer_Tick(object sender, EventArgs e)
        {
            bakuTime.Text = $"Time : {DateTime.Now:HH:mm:ss}";
            bakuDateLbl.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void londonbtn_MouseClick(object sender, MouseEventArgs e)
        {
            mytimer.Stop();
            bakuTimer.Stop();
            
            foreach (var control in Controls)
            {
                if (control is Label)
                {
                    (control as Label).Visible = false;
                }
            }
            bakuBackground.Stop();  
            londonBackground.Play();
            this.BackgroundImage = Resources._55_552679_london_wallpapers_hd_a6_data_src_london_street;
            londonLbl.Text = "London";
            londonLbl.ForeColor = Color.Black;          
            londonLbl.BackColor = Color.Transparent;
            londonLbl.Location = new Point(15, 510);
            londonLbl.AutoSize = true;
            londonLbl.Font = new Font("Bodoni MT", 30, FontStyle.Bold);
            londonDate.Text = "Date";
            londonDate.ForeColor = Color.Black;
            londonDate.BackColor = Color.Transparent;
            londonDate.Location = new Point(15, 560);
            londonDate.AutoSize = true;
            londonDate.Font = new Font("Bodoni MT", 30, FontStyle.Bold);
            londonLbl.Visible = true;
            londonDate.Visible = true;
            this.Controls.Add(londonLbl);
            this.Controls.Add(londonDate);      
            londonTimer.Interval = 1000;
            londonTimer.Tick += LondonTimer_Tick;
            londonTimer.Start();
        }

        private void LondonTimer_Tick(object sender, EventArgs e)
        {
            londonLbl.Text = $"Time : {DateTime.Now.AddHours(-4):HH:mm:ss}";
            londonDate.Text = DateTime.Now.AddHours(-4).ToLongDateString();
        }

        private void bakubtn_MouseClick_1(object sender, MouseEventArgs e)
        {
            mytimer.Stop();
            londonBackground.Stop();    
            bakuBackground.Play();
            londonTimer.Stop();
            foreach (var control in Controls)
            {
                if (control is Label)
                {
                    (control as Label).Visible = false;
                }
            }
            this.BackgroundImage = Resources.azerbaijan_tourism;
            bakuLbl.Text = "Baku";
            bakuLbl.ForeColor = Color.LightBlue;
            bakuLbl.BackColor = Color.Transparent;
            bakuLbl.Location = new Point(15, 10);
            bakuLbl.AutoSize = true;
            bakuLbl.Font = new Font("Bodoni MT", 30, FontStyle.Bold);
            bakuDate.Text = "Date";
            bakuDate.ForeColor = Color.LightBlue;
            bakuDate.BackColor = Color.Transparent;
            bakuDate.Location = new Point(500, 10);
            bakuDate.AutoSize = true;
            bakuDate.Font = new Font("Bodoni MT", 30, FontStyle.Bold);
            bakuDate.Visible = true;
            bakuLbl.Visible = true;
            this.Controls.Add(bakuLbl);
            this.Controls.Add(bakuDate);
            bakuTimer.Interval = 1000;
            bakuTimer.Tick += BakuTimer_Tick;
            bakuTimer.Start();
        }
        private void BakuTimer_Tick(object sender, EventArgs e)
        {
            bakuLbl.Text = $"Time : {DateTime.Now:HH:mm:ss}";
            bakuDate.Text = DateTime.Now.ToLongDateString();
        }

    }
}
