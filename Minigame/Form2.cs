using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using Minigame.Models;

namespace Minigame
{
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
       
        public class RoundButton : Button
        {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                var graphicsPath = new GraphicsPath();
                graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(graphicsPath);
                base.OnPaint(e);
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                this.ResumeLayout(false);

            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            animals ani = new animals();
            ani.ShowDialog();
            this.Show();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            job j = new job();
            j.ShowDialog();
            this.Show();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruit f = new Fruit();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sport sp = new sport();
            sp.ShowDialog();
            this.Show();
        }

        SoundPlayer vov = new SoundPlayer();
        private void Volume_Click(object sender, EventArgs e)
        {
            vov.Stop();
            pic_novolume.Visible = true;
            picvolumn.Visible = false;

        }
        private void NoVolume_Click(object sender, EventArgs e)
        {
            vov.SoundLocation = "abcd_song.wav";
            vov.Play();
            pic_novolume.Visible = false;
            picvolumn.Visible = true;

        }

        
    }

        
}
  



