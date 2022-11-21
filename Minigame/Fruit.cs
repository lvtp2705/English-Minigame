using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Minigame.Models; // import trong python
using System.Media;

namespace Minigame
{
    public partial class Fruit : Form
    {
        public Fruit()
        {
            InitializeComponent();
        }

        List<Image> img5 = new List<Image>(5);
        List<Image> img10 = new List<Image>();
        List<String> Name5 = new List<String>(5);
        List<String> Name10 = new List<String>(10);
        int diem = 0;
        int socau = 0;
        int dem = 0;
        int time = 20;
        int id = 0;
        private void Fruit_Load(object sender, EventArgs e)
        {
            string directory = @".\Fruits\";
            foreach (var myFile in Directory.GetFiles(directory, "*.jpg", SearchOption.AllDirectories))
            {
                img10.Add(Image.FromFile(myFile));
                Name10.Add(Path.GetFileNameWithoutExtension(myFile));
                //MessageBox.Show(Name10[0]);
            }
            int i = 0;
            img5.Clear();
            Random rd = new Random();
            while (i < 5)
            {
                int num = rd.Next(0, 10);
                if (check_image(img5, num, img5.Count()))
                {
                    img5.Add(img10[num]);
                    Name5.Add(Name10[num]);
                    i++;

                }
            }

            pictureBox1.BackgroundImage = img5[0];
            pictureBox1.Tag = Name5[0];


        }

        private bool check_image(List<Image> imgs, int num, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (img5[i] == img10[num])
                {
                    return false;
                }
            }
            return true;

        }
        private void check_result_Click(object sender, EventArgs e)
        {
            timedown_lb.Text = "20";
            DialogResult rs = new DialogResult();
            if (answer_txt.Text.ToLower().Trim() == pictureBox1.Tag.ToString().ToLower().Trim())
            {
                timer1.Stop();
                rs = MessageBox.Show("Excelent");
                answer_txt.Text = string.Empty;
                diem += 1;
                diem_lb.Text = $"{diem}";
                // cập nhật điểm

                RankDB context = new RankDB();
                rank r = context.ranks.Find(id);
                r.score += 1;
                r.timeplay = DateTime.Now;
                context.SaveChanges();
            }
            else
            {
                timer1.Stop();
                rs = MessageBox.Show("Wrong answer");
                answer_txt.Text = string.Empty;
            }

            dem += 1;

            if (rs == DialogResult.OK)
            {

                time = 20;
                timer1.Start();
                socau += 1;
                socau_lb.Text = $"{socau}/5";
            }

            if (dem == 5)
            {
                timer1.Stop();
                MessageBox.Show("THE END");
                diem = 0;
                socau = 0;
                dem = 0;
                // hiện điểm lên hoặc form nào muốn...
                start_pnl.Visible = true;
                name_txt.Text = "";
            }
            else
            {
                pictureBox1.Image = img5[dem];
                pictureBox1.Tag = Name5[dem];
            }


        }

        private void answer_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check_result_Click(sender, new EventArgs());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timedown_lb.Text = $"{time}";
            if (time == 0)
            {
                timer1.Stop();
                time = 20;
                check_result_Click(sender, e);
            }

            time -= 1;

        }
        private int addID(RankDB context)
        {
            int max = (from r in context.ranks select r.id).Max();
            if (max != null)
            {
                return max + 1;
            }
            else
            {
                return 1;
            }
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            start_pnl.Visible = false;
            RankDB context = new RankDB();
            rank new_rank = new rank
            {
                id = addID(context),
                name = name_txt.Text,
                score = 0,
                theme = "Fruits",
                timeplay = DateTime.Now
            };
            id = addID(context);
            context.ranks.Add(new_rank);
            context.SaveChanges();

            timer1.Start();
        }

        private void diem_lb_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
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
