using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HandWritenDetection;
using MathWorks.MATLAB.NET.Arrays;


namespace Matlab
{
    public partial class Form1 : Form
    {

        DetectionTools obj = null;
        MWArray LoadedImg;

        MWArray thresholdedImg;


        public Form1()
        {

            obj = new DetectionTools();


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = null;
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }

            LoadedImg = obj.Loadimg(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MWArray[] input = new MWArray[1];

            input[0] = LoadedImg;

            MWArray[] output = new MWArray[3];

            obj.ThreSholding(3,ref output, input);

             thresholdedImg = output[0];

            string message = Convert.ToString("# of Characters "+output[1]);

            MessageBox.Show(message);

        }



        private void button3_Click(object sender, EventArgs e)
        {

            MWArray[] wordsNumber = new MWArray[2];

            wordsNumber = obj.WordCounter(2, LoadedImg);

            string message = Convert.ToString("# of Words "+wordsNumber[1]);

            MessageBox.Show(message);

        }



        private void button4_Click(object sender, EventArgs e)
        {

            MWArray[] linenumbers = new MWArray[2];

            linenumbers = obj.LinesCount(2, thresholdedImg);

            string message = Convert.ToString("# of Lines "+linenumbers[1]);

            MessageBox.Show(message);

        }








    }
}
