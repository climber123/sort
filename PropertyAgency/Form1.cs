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

namespace PropertyAgency
{
    public partial class Agency : Form
    {
        
        public Agency()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("area", "area");
            dataGridView1.Columns.Add("floor", "floor");
            dataGridView1.Columns.Add("rooms", "rooms");
            dataGridView1.Columns.Add("square", "square");
            dataGridView1.Columns.Add("cost", "cost");
            dataGridView1.Columns.Add("count", "count");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Центральный", "Ленинский", "Коминтерновский", "Железнодорожный", "Левобережный", "Советский"});
            comboBox2.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox3.Items.AddRange(new string[] { "1", "2", "3", "4", "5"});
        }

        private void start_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            int m = 0;

            OpenFileDialog opn = new OpenFileDialog();

            if (opn.ShowDialog() != DialogResult.OK)
                return;

            StreamReader str = new StreamReader(opn.FileName);
            /*
            while (!str.EndOfStream)
            {
                string s = str.ReadLine();
                m++;
            };*/
            Flat[] flat = new Flat[22];
            
            while (!str.EndOfStream)
            {

                string s = str.ReadLine();
                string[] arr = s.Split( new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                flat[i] = new Flat(arr[0],
                    Convert.ToInt32(arr[1]),
                    Convert.ToInt32(arr[2]),
                    Convert.ToInt32(arr[3]),
                    Convert.ToInt32(arr[4]),
                    0);
                i++;
            }
            SortFlat stf = new SortFlat(/*flat,*/
                comboBox1.SelectedItem.ToString(),
                Convert.ToInt32(comboBox2.SelectedItem.ToString()),
                Convert.ToInt32(comboBox3.SelectedItem.ToString()),
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text),
                Convert.ToInt32(textBox2.Text),
                i);
            stf.ChoosePropertyFlat(flat);
            stf.Sort(flat);
            dataGridView1.RowCount = i;
            int k = 0;
            for (int l = i - 1; l >= 0; l--)
            {
                dataGridView1[0, k].Value = flat[l].Area;
                dataGridView1[1, k].Value = flat[l].Floor;
                dataGridView1[2, k].Value = flat[l].Rooms;
                dataGridView1[3, k].Value = flat[l].Square;
                dataGridView1[4, k].Value = flat[l].Cost;
                dataGridView1[5, k].Value = flat[l].Count;
                k++;
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
