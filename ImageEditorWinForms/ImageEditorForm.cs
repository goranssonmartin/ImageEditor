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
    public partial class ImageEditorForm : Form
    {
        public ImageEditorForm()
        {
            InitializeComponent();

            originalImage.Height = 250;
            originalImage.Width = 150;
            originalImage.SizeMode = PictureBoxSizeMode.Zoom;

            editedImage.Height = 250;
            editedImage.Width = 150;
            editedImage.SizeMode = PictureBoxSizeMode.Zoom;

            greyScaleButton.Enabled = false;
            negativeButton.Enabled = false;
            blurredButton.Enabled = false;
            saveFileButton.Enabled = false;
        }
        string imagePath = "";
        string currentImageSuffix = "";


        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files (*.PNG; *.JPG)| *.PNG; *.JPG";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                originalImage.Image = Image.FromFile(imagePath);
                greyScaleButton.Enabled = true;
                negativeButton.Enabled = true;
                blurredButton.Enabled = true;
                saveFileButton.Enabled = true;
            }
        }

        private void GreyScaleButton_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap greyScaleImage = ImageEditingProgram.MakeImageGreyScale(originalImage);

            editedImage.Image = greyScaleImage;
            currentImageSuffix = "_greyScale";
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap negativeImage = ImageEditingProgram.MakeImageNegative(originalImage);

            editedImage.Image = negativeImage;
            currentImageSuffix = "_negative";
        }

        private void BlurredButton_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap blurredImage = ImageEditingProgram.MakeImageBlurred(originalImage);

            editedImage.Image = blurredImage;
            currentImageSuffix = "_blurred";
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileNameWithoutExtension(imagePath);
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(imagePath);
            saveFileDialog.Filter = "Image Files (*.JPG)| *.JPG";
            saveFileDialog.FileName = fileName + currentImageSuffix;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                editedImage.Image.Save(saveFileDialog.FileName);
            }

        }
    }
}
