using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SortExample
{
    public partial class DrawSort : Form
    {
        static Graphics gs;
        static Graphics g;
        static Bitmap bitmap;
        static Rectangle r;
        private Button buttonRandom;
        static int col;
        public DrawSort()
        {
            InitializeComponent();
            Sort.Random();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            //int col = Convert.ToInt32(textBox1.Text);
            Sort.Random();
            Sort.Draw(g);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            gs = CreateGraphics();
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            g = Graphics.FromImage(bitmap);
            r = ClientRectangle;
        }
        public static void MyDraw()
        {
            g.Clear(Color.White);
            Sort.Draw(g);
            gs.DrawImage(bitmap, r);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MyDraw();
        }

        private void BubleSort_Click(object sender, EventArgs e)
        {
            Sort.StartSortBuble(g);
        }

        private void HoaraWithRec_Click(object sender, EventArgs e)
        {
            Sort.StartQuickSort(g);
        }

        private void HoaraWithStack_Click(object sender, EventArgs e)
        {
            Sort.QuickStack(g);
        }

        private void InitializeComponent()
        {
            this.buttonRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(855, 60);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click_1);
            // 
            // DrawSort
            // 
            this.ClientSize = new System.Drawing.Size(1264, 489);
            this.Controls.Add(this.buttonRandom);
            this.Name = "DrawSort";
            this.Load += new System.EventHandler(this.DrawSort_Load);
            this.ResumeLayout(false);

        }

        private void DrawSort_Load(object sender, EventArgs e)
        {

        }

        private void buttonRandom_Click_1(object sender, EventArgs e)
        {
     
        }
    }
}
