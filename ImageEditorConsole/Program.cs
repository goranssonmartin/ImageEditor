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
            string imagePath;
            Bitmap originalImage;
            try
            {
                imagePath = args[0];
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("File path not entered, please enter a path to an image file");
                imagePath = Console.ReadLine();
                imagePath = CheckIfGivenFileExists(imagePath);
            }


            originalImage = TryToCreateNewBitmap(imagePath);

            Bitmap greyScale = ImageEditingProgram.MakeImageGreyScale(originalImage);
            Bitmap negative = ImageEditingProgram.MakeImageNegative(originalImage);
            Bitmap blurred = ImageEditingProgram.MakeImageBlurred(originalImage);

            string storageDirectory = Path.GetDirectoryName(imagePath);
            string fileName = Path.GetFileNameWithoutExtension(imagePath);

            greyScale.Save(storageDirectory + "\\" + fileName + "_greyScale.jpg", ImageFormat.Jpeg);
            negative.Save(storageDirectory + "\\" + fileName + "_negative.jpg", ImageFormat.Jpeg);
            blurred.Save(storageDirectory + "\\" + fileName + "_blurred.jpg", ImageFormat.Jpeg);

        }
        public static Bitmap TryToCreateNewBitmap(string imagePath)
        {
            Bitmap originalImage;
            try
            {
                originalImage = new Bitmap(imagePath);
                return originalImage;
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Something went wrong, enter new image path");
                imagePath = Console.ReadLine();
                return TryToCreateNewBitmap(imagePath);
            }

        }

        public static string CheckIfGivenFileExists(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                return imagePath;
            }

            else
            {
                Console.WriteLine("Enter a valid filepath");
                imagePath = Console.ReadLine();
                return CheckIfGivenFileExists(imagePath);
            }


        }
    }
}
