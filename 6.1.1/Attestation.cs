using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramLogic;
using System.IO;

namespace _6._1._1
{
    public partial class Attestation : Form
    {
        RealList list;
        int ind = 0;
        MyQueue queue;
        MyStack stack;
        public Attestation()
        {
            InitializeComponent();
            list = new RealList();
            queue = new MyQueue();
            stack = new MyStack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = list.IsIncrease();
            if (r == 1)
                label1.Text = "Возрастает";
            else if (r == -1)
                label1.Text = "Убывает";
            else
                label1.Text = "Не убывает и не возрастает";
        }

        private void Create_Click(object sender, EventArgs e)
        {
            list.Clear();
            for (int i = 0; i < textBox2.Lines.Length; i++)
            {
                 list.Last(Convert.ToInt32(textBox2.Lines[i]));
                    
            }
            textBox3.Lines = list.Printer();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            list.Clear();
            ind = 0;
            textBox3.Lines = list.Printer();
        }

        private void AddLast_Click(object sender, EventArgs e)
        {
                    if (ind < textBox2.Lines.Length)
                    {
                        int k = Convert.ToInt32(textBox2.Lines[ind]);
                        ind++;
                        list.Last(k);
                        textBox3.Lines = list.Printer();
                    }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(textBox2.Text) == "")
            ind = 0;
        }

        private void AddFirst_Click(object sender, EventArgs e)
        {
          
                    if (ind < textBox2.Lines.Length)
                    {
                        int k = Convert.ToInt32(textBox2.Lines[ind]);
                        ind++;
                        list.Add_First(k);
                        textBox3.Lines = list.Printer();
                    }   

        }

        private void Create_Queue_Click(object sender, EventArgs e)
        { 
            queue.Clear();
            for (int i = 0; i < textBox2.Lines.Length; i++)
            {
                queue.Push(Convert.ToInt32(textBox2.Lines[i]));
                textBox3.Lines = queue.Printer();
            }    
        }

        private void Add_Queue_Click(object sender, EventArgs e)
        {

            if (ind < textBox2.Lines.Length)
            {

                int k = Convert.ToInt32(textBox2.Lines[ind]);
                ind++;
                queue.Push(k);
                textBox3.Lines = queue.Printer();
                        
            }
            
        }

        private void Clear_Queue_Click(object sender, EventArgs e)
        {
            queue.Clear();
            ind = 0;
            textBox3.Lines = queue.Printer();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            queue.Clear();
            textBox3.Lines = queue.Printer();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int k = rand.Next(-100, 101);
                queue.Push(k);
                textBox3.Lines = queue.Printer();
            }
        }

        private void Create_Stack_Click(object sender, EventArgs e)
        {
         
            
            stack.Clear();
            for (int i = 0; i < textBox2.Lines.Length; i++)
            {
                stack.Push(Convert.ToChar(textBox2.Lines[i]));
                textBox3.Lines = stack.Printer();
            }
        }

        private void Add_Stack_Click(object sender, EventArgs e)
        {
            if (ind < textBox2.Lines.Length)
            {
                char k = Convert.ToChar(textBox2.Lines[ind]);
                ind++;
                stack.Push(k);
                textBox3.Lines = stack.Printer();
            }
        }

        private void Clear_Stack_Click(object sender, EventArgs e)
        {
            stack.Clear();
            ind = 0;
            textBox3.Lines = stack.Printer();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Queue123.ResultQueue(queue);
            textBox3.Lines = queue.Printer();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;

                string text = File.ReadAllText(path);
                
                string[] arr_text = text.Split(' ');
                textBox2.Lines = arr_text;
     
            }
        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
               
                string[] a = textBox3.Lines;
                File.WriteAllLines(saveFile.FileName, a);
                
            }
        }

/*        public static void MakeD(string infname, string outfname, MyStack stack)
        {
            StreamReader sr = new StreamReader(infname);
            StreamWriter sw = new StreamWriter(outfname);
            int k = 0;
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (DigitStack.IsDigit(c))
                {
                    stack.Push(c);
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                sw.Write(stack.Pop());
            }

        }
 */

        private void start_button_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() != DialogResult.OK)
                return;
            if (saveFile.ShowDialog() != DialogResult.OK)
                return;
                
            //MessageBox.Show(openFile.FileName , saveFile.FileName);
            //MakeD(openFile.FileName, saveFile.FileName, stack);

            StreamReader sr = new StreamReader(openFile.FileName);
            StreamWriter sw = new StreamWriter(saveFile.FileName);
            int k = 0;
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (DigitStack.IsDigit(c))
                {
                    stack.Push(c);
                    k++;
                }
            }
            sr.Close();
            
            for (int i = 0; i < k; i++)
            {
                char n = stack.Pop();
                sw.Write(n);
               // stack.Push(n);
            }
            sw.Close();
            textBox3.Lines = stack.Printer();
        }

    }
}
