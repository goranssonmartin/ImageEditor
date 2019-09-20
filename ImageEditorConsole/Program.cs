using System;
using ImageEditor;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEditorConsole
{
    class Program
    {
        static void Main(string[] args)

        {
            string imagePath; // = @"C:\Users\94margor\Desktop\123.jpg";//args[0];
            try
            {
                imagePath = args[0];
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Type correct filepath for the image");
                imagePath = Console.ReadLine();
            }
            // try catch för args[0]!null och filepath = correct

            Bitmap originalImage = new Bitmap(imagePath);
            Bitmap greyScale = ImageEditingProgram.MakeImageGreyScale(originalImage);
            Bitmap negative = ImageEditingProgram.MakeImageNegative(originalImage);
            Bitmap blurred = ImageEditingProgram.MakeImageBlurred(originalImage);
            //new file = old.replace @. with _greyscale.jpg

            string storageDirectory = Path.GetDirectoryName(imagePath);
            string fileName = Path.GetFileNameWithoutExtension(imagePath);

            greyScale.Save(storageDirectory + "\\" + fileName + "_greyScale.jpg", ImageFormat.Jpeg);
            negative.Save(storageDirectory + "\\" + fileName + "_negative.jpg", ImageFormat.Jpeg);
            blurred.Save(storageDirectory + "\\" + fileName + "_blurred.jpg", ImageFormat.Jpeg);

        }
    }
}
