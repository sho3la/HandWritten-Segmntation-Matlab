using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matlab_HandWritten
{
    public partial class Form1 : Form
    {

        MLApp.MLApp matlab;

        public Form1()
        {
            InitializeComponent();

            matlab = new MLApp.MLApp();
        }


        ~Form1()
        {
            matlab.Execute("clear;");
        }



        private void Load_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(0);
            label5.Text = Convert.ToString(0);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog.FileName;


                    matlab = new MLApp.MLApp();

                    matlab.Execute("clear;");
                    matlab.Execute("original_img = imread('" + filename + "');");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }



        }


        /*
         * 
         *uniform threshold for balance illumanity in images  
         * work with image 1 , 2 , 5 , 6 , 7 , 8
         * 
         */
        private void UniformThreshold_Click(object sender, EventArgs e)
        {
            ///uniform thresholding
            matlab.Execute("gray = rgb2gray(original_img);");
            matlab.Execute("gray_double = double(gray);");
            matlab.Execute("res = imgaussfilt(gray_double,1) - imgaussfilt(gray_double,30);");
            matlab.Execute("res = res - min(res(:));");
            matlab.Execute("res = res / max(res(:));");
            matlab.Execute("T = res > graythresh(res);");
            matlab.Execute("res = ~T;");

            matlab.Execute("res = bwareaopen(res , 30);");
            matlab.Execute("res = bwmorph(res,'thick',1);");

            matlab.Execute("imshow(res);");

        }


        /*
         * 
         * non uniform threshold for balance illumanity in images  
         * work with image 3 , 4 , 9 , 10
         * 
         */
        private void NonUniformThreshold_Click(object sender, EventArgs e)
        {

            matlab.Execute("IM = mat2gray(original_img);");
            matlab.Execute("mIM = imfilter(IM,fspecial('average',50),'replicate');");
            matlab.Execute("sIM = mIM - IM - 0.1;");
            matlab.Execute("bw = im2bw(sIM,0);");
            matlab.Execute("res = imcomplement(bw);");

            matlab.Execute("res = ~res;");
            matlab.Execute("res = imclearborder(res);");
            matlab.Execute("res = bwareaopen(res,100);");
            matlab.Execute("se = strel('disk',2,4);");
            matlab.Execute("res = imerode(res,se);");
            matlab.Execute("res = bwmorph(res,'thicken',10);");
            matlab.Execute("res = bwmorph(res,'close',5);");
            matlab.Execute("imshow(res);");
        }




        private void CountLine_Click(object sender, EventArgs e)
        {
            matlab.Execute("[h , theta , rho] = hough(res);");
            matlab.Execute("peaks  = houghpeaks(h,10);");
            matlab.Execute("lines = houghlines(res,theta,rho,peaks);");
            matlab.Execute("t = lines.theta;");
            matlab.Execute("mean_theta = mean(t);");
            matlab.Execute("if mean_theta > 90 \n mean_theta = 180 - mean_theta; end ");
            matlab.Execute("horizontal_theta = 90 - mean_theta;");
            matlab.Execute("structure_elemnt = strel('line', size(res,2),horizontal_theta );");
            matlab.Execute("res = imdilate(res, structure_elemnt);");
            matlab.Execute("[~,num_lines] = bwlabel(res);");

            var lineCounts = matlab.GetVariable("num_lines", "base");


            if (lineCounts != null)
            {
                MessageBox.Show("Counting Done!!!");
            }

            label4.Text = Convert.ToString(lineCounts);
        }



        /*
         *
         * count characters of image not exactly ..
         * 
         * work with image 1 , 2 , 5 , 6 , 7 , 8
         * image 6 = 262 char
         */
        private void CountChars_Click(object sender, EventArgs e)
        {
            matlab.Execute("se = strel('disk',2,4);");
            matlab.Execute("res = imdilate(res,se);");
            matlab.Execute("CC = bwconncomp(res,4);");
            matlab.Execute("num_chars = CC.NumObjects;");

            var num_chars = matlab.GetVariable("num_chars", "base");

            if (num_chars != null)
            {
                MessageBox.Show("Counting Done!!!");
            }

            label5.Text = Convert.ToString(num_chars);
        }

        private void CountWords_Click(object sender, EventArgs e)
        {
            
            matlab.Execute("[h , theta , rho] = hough(res);");
            matlab.Execute("peaks  = houghpeaks(h,10);");
            matlab.Execute("lines = houghlines(res,theta,rho,peaks);");
            matlab.Execute("t = lines.theta;");
            matlab.Execute("mean_theta = mean(t);");
            matlab.Execute("if mean_theta > 90 \n mean_theta = 180 - mean_theta; end ");
            matlab.Execute("horizontal_theta = 90 - mean_theta;");
            matlab.Execute("se = strel('line',65,horizontal_theta);");
            matlab.Execute("horz = imdilate(res,se);");
            matlab.Execute("cc = bwconncomp(horz);");
            matlab.Execute("num_words = cc.NumObjects;");
            matlab.Execute("imshow(horz);");


            var wordCounts = matlab.GetVariable("num_words", "base");


            if (wordCounts != null)
            {
                MessageBox.Show("Counting Done!!!");
            }

            label6.Text = Convert.ToString(wordCounts);

        }










    }
}
