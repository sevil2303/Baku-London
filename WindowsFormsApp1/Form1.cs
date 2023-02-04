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
        public Form1()
        {
            InitializeComponent();           
            Timer mytimer = new Timer();
            mytimer.Interval = 1000;
            mytimer.Tick += Mytimer_Tick;
            mytimer.Start();
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
            foreach (var control in Controls)
            {
                if (control is Label)
                {
                    (control as Label).Visible = false;
                }
            }
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
            
            Timer londonTimer = new Timer();
            londonTimer.Interval = 1000;
            londonTimer.Tick += LondonTimer_Tick;
            londonTimer.Start();
        }

        private void LondonTimer_Tick(object sender, EventArgs e)
        {
            londonLbl.Text = $"Time : {DateTime.Now.AddHours(-4):HH:mm:ss}";
            londonDate.Text = DateTime.Now.ToLongDateString();
        }

        private void bakubtn_MouseClick_1(object sender, MouseEventArgs e)
        {
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
            Timer bakuTimer = new Timer();
            bakuTimer.Interval = 1000;
            bakuTimer.Tick += BakuTimer_Tick;
            bakuTimer.Start();
        }
        private void BakuTimer_Tick(object sender, EventArgs e)
        {
            bakuLbl.Text = $"Time : {DateTime.Now:HH:mm:ss}";
            bakuDate.Text = DateTime.Now.AddHours(-4).ToLongDateString();
        }

    }
}
