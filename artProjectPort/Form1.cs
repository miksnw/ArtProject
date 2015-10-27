using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace WindowsFormsApplication1
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            string [] kil;
            float[] RawL = new float[8];
            int num = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              
                    path = openFileDialog1.FileName;
                    //открываем файл
                    StreamReader ReadFile = File.OpenText(path);
                    string Input = null;
                    //Читаем из файла информацию
                    while ((Input = ReadFile.ReadLine()) != null)
                    {
                        //Console.WriteLine(Input);
                        kil=Input.Split(' ');
                        while (num < kil.Length)
                        {
                            richTextBox1.AppendText(kil[num]);
                            num = num + 1;
                        }
                    }
               
            }
        }
    }
}
