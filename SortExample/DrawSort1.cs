using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortExample
{
    public partial class DrawSort1 : Form
    {
        static Graphics gs;
        static Graphics g;
        static Bitmap bitmap;
        static Rectangle r;
        static int col;

        public DrawSort1()
        {
            InitializeComponent();
            Sort.Random();
        }

        private void DrawSort1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            gs = CreateGraphics();
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            g = Graphics.FromImage(bitmap);
            r = ClientRectangle;
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Sort.Random();
            Sort.Draw(g);
        }
        public static void MyDraw()
        {
            g.Clear(Color.White);
            Sort.Draw(g);
            gs.DrawImage(bitmap, r);

        }

        private void DrawSort1_Paint(object sender, PaintEventArgs e)
        {
            MyDraw();
        }

        private void Bubble_Click(object sender, EventArgs e)
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

        private void Show123_Click(object sender, EventArgs e)
        {
            ShowGraphics form = new ShowGraphics();
            form.Show();
        }
    }
}
