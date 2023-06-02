using System;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ConvertToHex
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;


        public Form1()
        {
            InitializeComponent();
            Submitbtn.Enabled = false;

            radioButton32x128.Enabled = false;
            radioButton32x64.Enabled = false;
            radioButton64x32.Enabled = false;
            radioButton64x64.Enabled = false;
            label1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "//[" + this.bitmap.Height.ToString() + "x" + this.bitmap.Width.ToString() + "]  (C) 2023 by PhamNghia_PhanAnhCuong\r\n";
            if (radioButton64x64.Checked || radioButton64x32.Checked)
            {
                int[][] Rtop = new int[32][];
                int[][] Gtop = new int[32][];
                int[][] Btop = new int[32][];
                int[][] Rbot = new int[32][];
                int[][] Gbot = new int[32][];
                int[][] Bbot = new int[32][];
                for (int i = 0; i < 32; i++)
                {
                    Rtop[i] = new int[bitmap.Width];
                    Gtop[i] = new int[bitmap.Width];
                    Btop[i] = new int[bitmap.Width];
                    Rbot[i] = new int[bitmap.Width];
                    Gbot[i] = new int[bitmap.Width];
                    Bbot[i] = new int[bitmap.Width];
                }
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        Color pixelColor = bitmap.GetPixel(j, i);
                        Rtop[i][j] = pixelColor.R;
                        Gtop[i][j] = pixelColor.G;
                        Btop[i][j] = pixelColor.B;
                    }
                }
                for (int i = 32; i < 64; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        Color pixelColor = bitmap.GetPixel(j, i);
                        Rbot[i-32][j] = pixelColor.R;
                        Gbot[i-32][j] = pixelColor.G;
                        Bbot[i-32][j] = pixelColor.B;
                    }
                }
                text = text + "//Red \r\n";
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)Rtop[i][j]/(double)byte.MaxValue * 31.0).ToString("X") + ",";
                    }
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)Rbot[i][j]/(double)byte.MaxValue * 31.0).ToString("X") + ",";
                    }
                }
                text += "\r\n";
                text += "//Green \r\n";

                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                         
                        text += "0x0" + round((double)Gtop[i][j] / (double)byte.MaxValue * 31.0).ToString("X") + ",";
                    }
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)Gbot[i][j] / (double)byte.MaxValue * 31.0).ToString("X") + ",";
                    }
                }
                text += "\r\n";
                text += "//Blue \r\n";
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)Btop[i][j] / (double)byte.MaxValue * 31.0).ToString("X") + ",";
                    }
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)Bbot[i][j] / (double)byte.MaxValue * 31.0).ToString("X") + ",";
                    }
                }
                text += "\r\n";
                textBox1.Text = text;
            }
            else if (radioButton32x128.Checked || radioButton32x64.Checked)
            {
                int[][] red = new int[32][];
                int[][] green = new int[32][];
                int[][] blue = new int[32][];
                for (int i = 0; i < 32; i++)
                {
                    red[i] = new int[bitmap.Width];
                    green[i] = new int[bitmap.Width];
                    blue[i] = new int[bitmap.Width];

                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        Color pixelColor = bitmap.GetPixel(j, i);
                        red[i][j] = pixelColor.R;
                        green[i][j] = pixelColor.G;
                        blue[i][j] = pixelColor.B;
                    }
                }

                text = text + "//Red \r\n";
                textBox1.Text = text;
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)red[i][j] / (double)byte.MaxValue *31.0) + ",";
                    }

                }
                text += "\r\n";
                text = text + "//Green \r\n";
                textBox1.Text = text;
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)green[i][j]/(double)byte.MaxValue * 31.0) + ",";
                    }

                }
                text += "\r\n";
                text = text + "//Blue \r\n";

                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += "0x0" + round((double)blue[i][j]/(double)byte.MaxValue * 31.0) + ",";
                    }
                }
                text += "\r\n";
                textBox1.Text = text;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            bitmap = new Bitmap(openFileDialog.FileName);
            pictureBox1.Image = this.bitmap;
            label1.Enabled = true;
            radioButton32x128.Enabled = true;
            radioButton32x64.Enabled = true;
            radioButton64x32.Enabled = true;
            radioButton64x64.Enabled = true;
            Submitbtn.Enabled = true;
            if (bitmap.Width == 64 && bitmap.Height == 32) radioButton32x64.Checked = true;
            else if (bitmap.Width == 32 && bitmap.Height == 64) radioButton64x32.Checked = true;
            else if (bitmap.Width == 64 && bitmap.Height == 64) radioButton64x64.Checked = true;
            else if (bitmap.Width == 128 && bitmap.Height == 32) radioButton32x128.Checked = true;
            else
            {
                radioButton32x128.Checked = false;
                radioButton32x64.Checked = false;
                radioButton64x32.Checked = false;
                radioButton64x64.Checked = false;
            }
        }

        private void Copybtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Empty!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                Clipboard.SetText(this.textBox1.Text);
                MessageBox.Show("Đã Copy", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
        private int round(double so)
        {
            so += 0.5;
            return (int)so;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void radioButton32x64_CheckedChanged(object sender, EventArgs e)
        {
            int newWidth = bitmap.Width; // Chiều rộng mới
            int newHeight = bitmap.Height; // Chiều cao mới
            Bitmap originalImage = new Bitmap(pictureBox1.Image); //lấy link từ pict.b
            newWidth = 64;
            newHeight = 32;
            Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);
            bitmap = resizedImage;
            pictureBox1.Image = bitmap;
            Submitbtn.Enabled = true;

        }

        private void radioButton64x32_CheckedChanged(object sender, EventArgs e)
        {
            int newWidth = bitmap.Width; // Chiều rộng mới
            int newHeight = bitmap.Height; // Chiều cao mới
            Bitmap originalImage = new Bitmap(pictureBox1.Image); //lấy link từ pict.b
            newWidth = 32;
            newHeight = 64;
            Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);
            bitmap = resizedImage;
            pictureBox1.Image = bitmap;
            Submitbtn.Enabled = true;
        }

        private void radioButton32x128_CheckedChanged(object sender, EventArgs e)
        {
            int newWidth = bitmap.Width; // Chiều rộng mới
            int newHeight = bitmap.Height; // Chiều cao mới
            Bitmap originalImage = new Bitmap(pictureBox1.Image); //lấy link từ pict.b
            newWidth = 128;
            newHeight = 32;
            Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);
            bitmap = resizedImage;
            pictureBox1.Image = bitmap;
            Submitbtn.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void radioButton64x64_CheckedChanged(object sender, EventArgs e)
        {
            int newWidth = bitmap.Width; // Chiều rộng mới
            int newHeight = bitmap.Height; // Chiều cao mới
            Bitmap originalImage = new Bitmap(pictureBox1.Image); //lấy link từ pict.b
            newWidth = 64;
            newHeight = 64;
            Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);
            bitmap = resizedImage;
            pictureBox1.Image = bitmap;
            Submitbtn.Enabled = true;
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}