using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;

namespace Görüntü_işleme
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection kameralar;
        private VideoCaptureDevice sonKare;
        int takip,Red,Green,Blue,redMax,greenMax,blueMax;

        public Form1()
        {
            InitializeComponent();
            kameralar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo kamera in kameralar)
            {
                comboBox1.Items.Add(kamera.Name);
            }
            comboBox1.SelectedIndex = 0;
            sonKare = new VideoCaptureDevice();
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void griTonlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 gri = new GrayscaleBT709();
            pictureBox2.Image = gri.Apply((Bitmap)pictureBox1.Image);
        }

        private void kameraAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sonKare = new VideoCaptureDevice(kameralar[comboBox1.SelectedIndex].MonikerString);
            sonKare.NewFrame += new NewFrameEventHandler(sonYeni);
            sonKare.Start();
            
        }

        private void sonYeni(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap video= (Bitmap)eventArgs.Frame.Clone();
            if (takip == 1)
            {
                ColorFiltering colorfilter = new ColorFiltering();
                colorfilter.Red = new IntRange(Red, redMax);
                colorfilter.Green = new IntRange(Green, greenMax);
                colorfilter.Blue = new IntRange(Blue, blueMax);
                colorfilter.ApplyInPlace(video);
                BlobCounter blobCounter = new BlobCounter();
                blobCounter.MinHeight = 20;
                blobCounter.MinWidth = 20;
                blobCounter.ObjectsOrder = ObjectsOrder.Size;
                blobCounter.ProcessImage(video);
                Rectangle[] rect = blobCounter.GetObjectsRectangles();
                if(rect.Length>0)
                {
                    Rectangle obj= rect[0];
                    Graphics gr = Graphics.FromImage(video);
                    using (Pen pen = new Pen(Color.White, 3))
                    {
                        gr.DrawRectangle(pen, obj);
                    }
                    gr.Dispose();
                }
                pictureBox2.Image = video;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sonKare.IsRunning==true)
            {
                sonKare.Stop();
            }
        }

        private void red_Scroll(object sender, EventArgs e)
        {
            Red = (int)red.Value;
            numericUpDownRed.Value = Red;
        }

        private void greenTrackMax_Scroll(object sender, EventArgs e)
        {
            greenMax = (int)greenTrackMax.Value;
            numericUpDownGreenMax.Value = greenMax;
        }

        private void blueTrackMax_Scroll(object sender, EventArgs e)
        {
            blueMax = (int)blueTrackMax.Value;
            numericUpDownBlueMax.Value = blueMax;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void green_Scroll(object sender, EventArgs e)
        {
            Green = (int)green.Value;
            numericUpDownGreen.Value = Green;
        }

        private void blue_Scroll(object sender, EventArgs e)
        {
            Blue = (int)blue.Value;
            numericUpDownBlue.Value = Blue;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            redMax = (int)redTrackMax.Value;
            numericUpDownRedMax.Value = redMax;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sonKare.IsRunning==true)
            {
                pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            }
            else
            {
                MessageBox.Show("Önce Kamera Aç!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Save(@"C:\goruntu.bmp", ImageFormat.Bmp);
                MessageBox.Show("Kaydedildi");
            }
            else MessageBox.Show("Önce Fotoğraf Çek");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            takip = 1;
        }
    }
}
