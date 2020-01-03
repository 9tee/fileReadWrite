using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace fileReadWrite
{
    public partial class Form1 : Form
    {
        Queue<string> stringQueue;
        StreamWriter writer;
        Timer timer;
        
        public Form1()
        {
            InitializeComponent();
            stringQueue = new Queue<string>();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var _strDequeue = stringQueue.Dequeue();
            Console.WriteLine("write string: " + _strDequeue + " Remaining:" + stringQueue.Count);
            writer.WriteLine(_strDequeue);
            writer.Flush();
            if(stringQueue.Count == 0)
            {
                timer.Stop();
                MessageBox.Show("Finished");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = Convert.ToInt32(textBox1.Text);
            using (StreamReader reader = new StreamReader(input.Text))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    stringQueue.Enqueue(reader.ReadLine());
                }
            }
            writer = new StreamWriter(output.Text, append: false);
            timer.Start();
        }

        private void FileBt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            output.Text = saveFileDialog1.FileName;
        }

        private void InputBt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            input.Text = openFileDialog1.FileName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
            writer.Dispose();
        }
    }
}
