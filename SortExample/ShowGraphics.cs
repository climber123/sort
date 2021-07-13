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
    public partial class ShowGraphics : Form
    {
        public ShowGraphics()
        {
            InitializeComponent();
        }

        private void Graphics_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();

            for (int i = 100; i < 200; i += 10)
            {
                Info[] arr =  Graphics1.Random(i);
                int[] count = Graphics1.StartSortBuble(arr);
                chart1.Series[0].Points.AddXY(arr.Length, count[0]);
                chart2.Series[0].Points.AddXY(arr.Length, count[1]);
            }

            for (int i = 100; i < 1000; i += 10)
            {
                Info[] arr = Graphics1.Random(i);
                int[] count = Graphics1.StartQuickSort(arr);
                chart1.Series[1].Points.AddXY(arr.Length, count[0]);
                chart2.Series[1].Points.AddXY(arr.Length, count[1]);
            }
            for (int i = 100; i < 1000; i += 10)
            {
                Info[] arr = Graphics1.Random(i);
                int[] count = Graphics1.QuickStack(arr);
                chart1.Series[2].Points.AddXY(arr.Length, count[0]);
                chart2.Series[2].Points.AddXY(arr.Length, count[1]);
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
