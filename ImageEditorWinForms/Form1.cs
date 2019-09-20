using ImageEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imagePath;
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files (*.PNG; *.JPG)| *.PNG; *.JPG";    
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.Height = 250;
                pictureBox1.Width = 150;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap greyScale = ImageEditingProgram.MakeImageGreyScale(originalImage);

            pictureBox2.Image = greyScale;
            pictureBox2.Height = 250;
            pictureBox2.Width = 150;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap negative = ImageEditingProgram.MakeImageNegative(originalImage);

            pictureBox2.Image = negative;
            pictureBox2.Height = 250;
            pictureBox2.Width = 150;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap blurred = ImageEditingProgram.MakeImageBlurred(originalImage);

            pictureBox2.Image = blurred;
            pictureBox2.Height = 250;
            pictureBox2.Width = 150;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
