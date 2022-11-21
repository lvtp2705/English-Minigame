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

namespace Minigame
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<Image> img5 = new List<Image>(5);
        List<Image> img10 = new List<Image>();
        List<String> Name5 = new List<String>(5);
        List<String> Name10 = new List<String>(10);
        int diem = 0;
        int socau = 1;
        int dem = 0;

        private void Form3_Load(object sender, EventArgs e)
        {   
            string directory = @".\Animals\";
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

            if (answer_txt.Text.ToLower().Trim() == pictureBox1.Tag.ToString().ToLower().Trim())
            {
                MessageBox.Show("Chinh Xac");
                diem += 1;
                diem_lb.Text = $"{diem}";
            }
            else
            {
                MessageBox.Show("Khong Chinh Xac");
            }
            dem += 1;
            socau += 1;
            socau_lb.Text = $"{socau}/5";

            pictureBox1.Image = img5[dem];
            pictureBox1.Tag = Name5[dem];

        }

        private void answer_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check_result_Click(sender, new EventArgs());
            }
        }
       
       
    }

    
}
