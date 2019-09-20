using ImageEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

            pictureBox1.Height = 250;
            pictureBox1.Width = 150;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.Height = 250;
            pictureBox2.Width = 150;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
        string imagePath="";
        
        
        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files (*.PNG; *.JPG)| *.PNG; *.JPG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap greyScale = ImageEditingProgram.MakeImageGreyScale(originalImage);

            pictureBox2.Image = greyScale;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap negative = ImageEditingProgram.MakeImageNegative(originalImage);

            pictureBox2.Image = negative;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap blurred = ImageEditingProgram.MakeImageBlurred(originalImage);

            pictureBox2.Image = blurred;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Image Files (*.JPG)| *.JPG";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(imagePath);
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
            
        }
    }
}
