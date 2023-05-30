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
                string[][] Rtop = new string[32][];
                string[][] Gtop = new string[32][];
                string[][] Btop = new string[32][];
                string[][] Rbot = new string[32][];
                string[][] Gbot = new string[32][];
                string[][] Bbot = new string[32][];
                for (int i = 0; i < 32; i++)
                {
                    Rtop[i] = new string[bitmap.Width];
                    Gtop[i] = new string[bitmap.Width];
                    Btop[i] = new string[bitmap.Width];
                    Rbot[i] = new string[bitmap.Width];
                    Gbot[i] = new string[bitmap.Width];
                    Bbot[i] = new string[bitmap.Width];
                }
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        Color pixelColor = bitmap.GetPixel(j, i);
                        Rtop[i][j] = "0x" + pixelColor.R.ToString("X");
                        Gtop[i][j] = "0x" + pixelColor.G.ToString("X");
                        Btop[i][j] = "0x" + pixelColor.B.ToString("X");
                    }
                }

                for (int i = 32; i < 64; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        Color pixelColor = bitmap.GetPixel(j, i);
                        Rbot[i - 32][j] = "0x" + pixelColor.R.ToString("X");
                        Gbot[i - 32][j] = "0x" + pixelColor.G.ToString("X");
                        Bbot[i - 32][j] = "0x" + pixelColor.B.ToString("X");
                    }
                }

                text = text + "//Red \r\n";
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += Rtop[i][j] + ",";

                    }

                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += Rbot[i][j] + ",";

                    }
                }
                text += "\r\n";
                text += "//Green \r\n";
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += Rtop[i][j] + ",";

                    }

                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += Gbot[i][j] + ",";

                    }
                }
                text += "\r\n";
                text += "//Blue \r\n";
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += Btop[i][j] + ",";

                    }

                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += Bbot[i][j] + ",";

                    }
                }
                text += "\r\n";
                textBox1.Text = text;
            }
            else if (radioButton32x128.Checked || radioButton32x64.Checked)
            {
                string[][] red = new string[32][];
                string[][] green = new string[32][];
                string[][] blue = new string[32][];
                for (int i = 0; i < 32; i++)
                {
                    red[i] = new string[bitmap.Width];
                    green[i] = new string[bitmap.Width];
                    blue[i] = new string[bitmap.Width];

                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        Color pixelColor = bitmap.GetPixel(j, i);
                        red[i][j] = "0x" + pixelColor.R.ToString("X");
                        green[i][j] = "0x" + pixelColor.G.ToString("X");
                        blue[i][j] = "0x" + pixelColor.B.ToString("X");
                    }
                }

                text = text + "//Red \r\n";
                textBox1.Text = text;
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += red[i][j] + ",";
                    }

                }
                text += "\r\n";
                text = text + "//Green \r\n";
                textBox1.Text = text;
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += green[i][j] + ",";
                    }

                }
                text += "\r\n";
                text = text + "//Blue \r\n";

                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        text += blue[i][j] + ",";
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
    }
}