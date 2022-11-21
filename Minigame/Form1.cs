using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Minigame.Models;

namespace Minigame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
        }

        SoundPlayer vov = new SoundPlayer();
        List<Class1> ds = new List<Class1>();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 M = new Form2();
            M.ShowDialog();
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Volume_Click(object sender, EventArgs e)
        {
            vov.Stop();
            pic_novolume.Visible = true;
            picvolumn.Visible = false;

        }
        private void NoVolume_Click(object sender, EventArgs e)
        {          
            vov.Play();
            pic_novolume.Visible = false;
            picvolumn.Visible = true;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            vov.SoundLocation = "abcd_song.wav";
            vov.Play();
            

            Class1 cl;

            cl = new Class1() { ID = "1", Type = "Fruit", English = "Apple", VietNamese = "Táo" };
            ds.Add(cl);
            cl = new Class1() { ID = "2", Type = "Fruit", English = "Coconut", VietNamese = "Dừa" };
            ds.Add(cl);
            cl = new Class1() { ID = "3", Type = "Fruit", English = "Grape", VietNamese = "Nho" };
            ds.Add(cl);
            cl = new Class1() { ID = "4", Type = "Fruit", English = "Kiwi", VietNamese = "Quả kiwi" };
            ds.Add(cl);
            cl = new Class1() { ID = "5", Type = "Fruit", English = "Orange", VietNamese = "Cam" };
            ds.Add(cl);
            cl = new Class1() { ID = "6", Type = "Fruit", English = "Strawberries", VietNamese = "Dâu tây" };
            ds.Add(cl);
            cl = new Class1() { ID = "7", Type = "Fruit", English = "Dragon fruit", VietNamese = "Thanh long" };
            ds.Add(cl);
            cl = new Class1() { ID = "8", Type = "Fruit", English = "Pomegranate", VietNamese = "Lựu" };
            ds.Add(cl);
            cl = new Class1() { ID = "9", Type = "Fruit", English = "Plum", VietNamese = "Mận" };
            ds.Add(cl);
            cl = new Class1() { ID = "10", Type = "Fruit", English = "Pineapple", VietNamese = "Khóm" };
            ds.Add(cl);
            cl = new Class1() { ID = "11", Type = "Fruit", English = "Watermelon", VietNamese = "Dưa hấu" };
            ds.Add(cl);
            cl = new Class1() { ID = "12", Type = "Fruit", English = "Avocado", VietNamese = "Bơ" };
            ds.Add(cl);

            cl = new Class1() { ID = "11", Type = "Animal", English = "Dog", VietNamese = "Chó" };
            ds.Add(cl);
            cl = new Class1() { ID = "12", Type = "Animals", English = "Cat", VietNamese = "Mèo" };
            ds.Add(cl);
            cl = new Class1() { ID = "13", Type = "Animals", English = "Panda", VietNamese = "Gấu trúc" };
            ds.Add(cl);
            cl = new Class1() { ID = "14", Type = "Animals", English = "Tiger", VietNamese = "Hổ" };
            ds.Add(cl);
            cl = new Class1() { ID = "15", Type = "Animals", English = "Rabbit", VietNamese = "Thỏ" };
            ds.Add(cl);
            cl = new Class1() { ID = "16", Type = "Animals", English = "Pig", VietNamese = "Heo" };
            ds.Add(cl);
            cl = new Class1() { ID = "17", Type = "Animals", English = "Giraffe", VietNamese = "Hươu cao cổ" };
            ds.Add(cl);
            cl = new Class1() { ID = "18", Type = "Animals", English = "Eagle", VietNamese = "Chim đại bàng" };
            ds.Add(cl);
            cl = new Class1() { ID = "19", Type = "Animals", English = "Monkey", VietNamese = "Khỉ" };
            ds.Add(cl);
            cl = new Class1() { ID = "20", Type = "Animals", English = "Turtle", VietNamese = "Rùa" };
            ds.Add(cl);
            cl = new Class1() { ID = "21", Type = "Animals", English = "Parrot", VietNamese = "Vẹt" };
            ds.Add(cl);

            cl = new Class1() { ID = "22", Type = "Job", English = "Teacher", VietNamese = "Giáo viên" };
            ds.Add(cl);
            cl = new Class1() { ID = "23", Type = "Job", English = "Doctor", VietNamese = "Bác sĩ" };
            ds.Add(cl);
            cl = new Class1() { ID = "24", Type = "Job", English = "Police", VietNamese = "Cảnh sát" };
            ds.Add(cl);
            cl = new Class1() { ID = "25", Type = "Job", English = "Student", VietNamese = "Học sinh" };
            ds.Add(cl);
            cl = new Class1() { ID = "26", Type = "Job", English = "Pilot", VietNamese = "Phi công" };
            ds.Add(cl);
            cl = new Class1() { ID = "27", Type = "Job", English = "Waiter", VietNamese = "Phục vụ nam" };
            ds.Add(cl);
            cl = new Class1() { ID = "28", Type = "Job", English = "Fireman", VietNamese = "Lính cứu hỏa" };
            ds.Add(cl);
            cl = new Class1() { ID = "28", Type = "Job", English = "Worker", VietNamese = "Công nhân" };
            ds.Add(cl);
            cl = new Class1() { ID = "30", Type = "Job", English = "Chef", VietNamese = "Đầu bếp" };
            ds.Add(cl);
            cl = new Class1() { ID = "31", Type = "Job", English = "Photographer", VietNamese = "Thợ chụp ảnh" };
            ds.Add(cl);
            cl = new Class1() { ID = "32", Type = "Job", English = "Singer", VietNamese = "Ca sĩ" };
            ds.Add(cl);

            cl = new Class1() { ID = "33", Type = "Sport", English = "Soccer", VietNamese = "Đá bóng" };
            ds.Add(cl);
            cl = new Class1() { ID = "34", Type = "Sport", English = "Voleyball", VietNamese = "Bóng chuyền" };
            ds.Add(cl);
            cl = new Class1() { ID = "35", Type = "Sport", English = "Baseball", VietNamese = "Bóng chày" };
            ds.Add(cl);
            cl = new Class1() { ID = "36", Type = "Sport", English = "Basketball", VietNamese = "Bóng rổ" };
            ds.Add(cl);
            cl = new Class1() { ID = "37", Type = "Sport", English = "Cycling", VietNamese = "Đạp xe đạp" };
            ds.Add(cl);
            cl = new Class1() { ID = "38", Type = "Sport", English = "Aerobic", VietNamese = "Phục vụ nam" };
            ds.Add(cl);
            cl = new Class1() { ID = "39", Type = "Sport", English = "Swimming", VietNamese = "Bơi lội" };
            ds.Add(cl);
            cl = new Class1() { ID = "40", Type = "Sport", English = "Table tennis", VietNamese = "Bóng bàn" };
            ds.Add(cl);
            cl = new Class1() { ID = "41", Type = "Sport", English = "Skiing", VietNamese = "Trượt tuyết" };
            ds.Add(cl);
            cl = new Class1() { ID = "42", Type = "Sport", English = "Badminton", VietNamese = "Cầu lông" };
            ds.Add(cl);
            cl = new Class1() { ID = "43", Type = "Sport", English = "Golf", VietNamese = "Đánh golf" };
            ds.Add(cl);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dataGridView.DataSource = ds;
            dataGridView.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel1_Load(object sender, PaintEventArgs e)
        {
           
           
            //dataGridView.DataSource = ds;// 

        }

        private void pic_volume_Click(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RankDB context = new RankDB();
            var rs = context.ranks.ToList();
            dataGridView.DataSource = rs;
            //dataGridView.Columns["timeplay"].DefaultCellStyle.Format = "dd/MM/yyyy"; // nếu muốn hiện cả giờ thì bỏ cmt dòng này
            panel1.Visible = true;
        }

        private void rankBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}