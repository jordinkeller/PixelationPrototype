using AForge.Imaging.ColorReduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelationPrototypeWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap originalImage;
        public int pixelSize;
        public int colorReductionAmount = 0;
        public int width;
        public int height;

        private void UI_btnChoosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "E:\\Downloads";
            openFileDialog.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    width = originalImage.Width;
                    height = originalImage.Height;

                    // Adjust form and update UI
                    UI_PictureViewer.Width = originalImage.Width;
                    UI_PictureViewer.Height = originalImage.Height;
                    UI_PictureViewer.Image = originalImage;
                    UI_lblFileLocation.Text = openFileDialog.FileName;
                    this.Width = UI_PictureViewer.Width + 95;
                    this.Height = UI_PictureViewer.Height + 95;
                    CheckPixelSize(UI_txtPixelSize.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error loading picture.");
                }
            }
        }

        private void UI_btnPixelate_Click(object sender, EventArgs e)
        {
            Pixelate((Bitmap)UI_PictureViewer.Image, pixelSize);
        }

        private void Pixelate(Bitmap originalImage, int pixelSize)
        {
            var pixelatedImage = new Bitmap(originalImage);

            var pixelBlocksWidth = width / pixelSize;
            var pixelBlockHeight = height / pixelSize;

            // the image is divided into blocks, determined by pixelSize
            // loop through the blocks and change the color
            for (int x = 0; x < width; x+= pixelSize)
            {
                for (int y = 0; y < height; y+= pixelSize)
                {
                    PixelateBlock((Bitmap)pixelatedImage, x, y, pixelSize);
                }
            }

            UI_PictureViewer.Image = (Bitmap)pixelatedImage;
        }

        private void PixelateBlock(Bitmap image, int x, int y, int pixelSize)
        {
            // get the all of the colors within the block into a list
            List<Color> colorList = new List<Color>();
            for (int i = x; i < x + pixelSize; i++)
            {
                for (int j = y; j < y + pixelSize; j++)
                {
                    colorList.Add(image.GetPixel(i, j));
                }
            }

            // find the average of the colors
            var averageColor = GetAverageColor(colorList);

            // assign all the colors in block to the average color
            for (int i = x; i < x + pixelSize; i++)
            {
                for (int j = y; j < y + pixelSize; j++)
                {
                    image.SetPixel(i, j, averageColor);
                }
            }
        }

        private Color GetAverageColor (List<Color> colorList)
        {
            List<int> redValueList = new List<int>();
            List<int> blueValueList = new List<int>();
            List<int> greenValueList = new List<int>();
            foreach (Color color in colorList)
            {
                redValueList.Add(color.R);
                blueValueList.Add(color.B);
                greenValueList.Add(color.G);
            }

            return Color.FromArgb((int)redValueList.Average(), (int)greenValueList.Average(), (int)blueValueList.Average());
        }

        private void CheckPixelSize(string num)
        {
            int temp;
            if (int.TryParse(num, out temp))
            {
                if (temp > 0)
                {
                    pixelSize = temp;
                    CheckForCleanNumber(pixelSize);
                }
            }
            else
                UI_btnPixelate.Enabled = false;
        }

        private void CheckForCleanNumber(int num)
        {
            if (width % num == 0 && height % num == 0)
                UI_btnPixelate.Enabled = true;
            else
                UI_btnPixelate.Enabled = false;

        }

        private void UI_txtPixelSize_TextChanged(object sender, EventArgs e)
        {
            CheckPixelSize(UI_txtPixelSize.Text);
        }

        private void RoundColors(Bitmap image)
        {
            ColorImageQuantizer ciq = new ColorImageQuantizer(new MedianCutQuantizer());
            //Color[] colorTable = ciq.CalculatePalette((Bitmap)UI_PictureViewer.Image, 16);

            UI_PictureViewer.Image = ciq.ReduceColors(image, colorReductionAmount);
        }

        private void UI_btnReduceColors_Click(object sender, EventArgs e)
        {
            RoundColors((Bitmap)UI_PictureViewer.Image);
        }

        private void UpdateColorReductionAmount(int num)
        {
            if (num > 2 && num < 256)
            {
                colorReductionAmount = num;
                UI_btnReduceColors.Enabled = true;
            }
        }

        private void UI_txtColorReduction_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(UI_txtColorReduction.Text, out temp))
                UpdateColorReductionAmount(temp);
        }
    }
}
