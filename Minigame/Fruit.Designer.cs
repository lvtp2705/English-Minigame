
namespace Minigame
{
    partial class Fruit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruit));
            this.start_pnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.timedown_lb = new System.Windows.Forms.Label();
            this.answer_txt = new System.Windows.Forms.TextBox();
            this.socau_lb = new System.Windows.Forms.Label();
            this.diem_lb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picvolumn = new System.Windows.Forms.Button();
            this.pic_novolume = new System.Windows.Forms.Button();
            this.start_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_pnl
            // 
            this.start_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_pnl.BackColor = System.Drawing.Color.Transparent;
            this.start_pnl.Controls.Add(this.label3);
            this.start_pnl.Controls.Add(this.name_txt);
            this.start_pnl.Controls.Add(this.start_btn);
            this.start_pnl.Location = new System.Drawing.Point(33, 65);
            this.start_pnl.Name = "start_pnl";
            this.start_pnl.Size = new System.Drawing.Size(1002, 567);
            this.start_pnl.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(213, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Your Name: ";
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(368, 143);
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(300, 43);
            this.name_txt.TabIndex = 23;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_btn
            // 
            this.start_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start_btn.BackColor = System.Drawing.Color.Red;
            this.start_btn.Font = new System.Drawing.Font("ROG Fonts", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.Yellow;
            this.start_btn.Location = new System.Drawing.Point(406, 216);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(227, 86);
            this.start_btn.TabIndex = 22;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // timedown_lb
            // 
            this.timedown_lb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timedown_lb.Font = new System.Drawing.Font("Sitka Banner", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedown_lb.Location = new System.Drawing.Point(828, 89);
            this.timedown_lb.Name = "timedown_lb";
            this.timedown_lb.Size = new System.Drawing.Size(142, 119);
            this.timedown_lb.TabIndex = 31;
            this.timedown_lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answer_txt
            // 
            this.answer_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answer_txt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_txt.Location = new System.Drawing.Point(389, 498);
            this.answer_txt.Name = "answer_txt";
            this.answer_txt.Size = new System.Drawing.Size(244, 43);
            this.answer_txt.TabIndex = 30;
            this.answer_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answer_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answer_txt_KeyDown);
            // 
            // socau_lb
            // 
            this.socau_lb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.socau_lb.AutoSize = true;
            this.socau_lb.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socau_lb.Location = new System.Drawing.Point(954, 288);
            this.socau_lb.Name = "socau_lb";
            this.socau_lb.Size = new System.Drawing.Size(67, 24);
            this.socau_lb.TabIndex = 28;
            this.socau_lb.Text = "0/5";
            // 
            // diem_lb
            // 
            this.diem_lb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.diem_lb.AutoSize = true;
            this.diem_lb.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diem_lb.Location = new System.Drawing.Point(954, 234);
            this.diem_lb.Name = "diem_lb";
            this.diem_lb.Size = new System.Drawing.Size(28, 24);
            this.diem_lb.TabIndex = 29;
            this.diem_lb.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(-1, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(458, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "CHECK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.check_result_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(820, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "NUMBER";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(820, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "SCORE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(277, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picvolumn
            // 
            this.picvolumn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picvolumn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picvolumn.BackgroundImage")));
            this.picvolumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picvolumn.FlatAppearance.BorderSize = 0;
            this.picvolumn.Location = new System.Drawing.Point(80, -1);
            this.picvolumn.Name = "picvolumn";
            this.picvolumn.Size = new System.Drawing.Size(75, 59);
            this.picvolumn.TabIndex = 58;
            this.picvolumn.UseVisualStyleBackColor = false;
            this.picvolumn.Click += new System.EventHandler(this.Volume_Click);
            // 
            // pic_novolume
            // 
            this.pic_novolume.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pic_novolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_novolume.BackgroundImage")));
            this.pic_novolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_novolume.FlatAppearance.BorderSize = 0;
            this.pic_novolume.Location = new System.Drawing.Point(80, -1);
            this.pic_novolume.Name = "pic_novolume";
            this.pic_novolume.Size = new System.Drawing.Size(75, 60);
            this.pic_novolume.TabIndex = 59;
            this.pic_novolume.UseVisualStyleBackColor = false;
            this.pic_novolume.Visible = false;
            this.pic_novolume.Click += new System.EventHandler(this.NoVolume_Click);
            // 
            // Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 644);
            this.Controls.Add(this.pic_novolume);
            this.Controls.Add(this.picvolumn);
            this.Controls.Add(this.start_pnl);
            this.Controls.Add(this.timedown_lb);
            this.Controls.Add(this.answer_txt);
            this.Controls.Add(this.socau_lb);
            this.Controls.Add(this.diem_lb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Fruit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit";
            this.Load += new System.EventHandler(this.Fruit_Load);
            this.start_pnl.ResumeLayout(false);
            this.start_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel start_pnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label timedown_lb;
        private System.Windows.Forms.TextBox answer_txt;
        private System.Windows.Forms.Label socau_lb;
        private System.Windows.Forms.Label diem_lb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button picvolumn;
        private System.Windows.Forms.Button pic_novolume;
    }
}