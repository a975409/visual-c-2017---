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

namespace Ex12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string file1 = @"c:\work\text1.txt";
        string file2 = @"c:\work\text2.txt";
        string file3 = @"c:\work\text3.txt";
        string data = "";
       
    private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader fIn1 = new StreamReader(file1);
            data = fIn1.ReadToEnd();
            FileInfo f1Info = new FileInfo(file3);  
            StreamWriter sw1 = f1Info.CreateText();
            sw1.WriteLine(data);
            sw1.WriteLine();
            sw1.Close();

            StreamReader fIn2 = new StreamReader(file2);
            data = fIn2.ReadToEnd();
            FileInfo f2Info = new FileInfo(file3);
            StreamWriter sw2 = f2Info.AppendText();
            sw2.WriteLine(data);
            sw2.Close();
        }
    }
}
