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
            }

            bool validImageFile = FileHandler.CheckIfGivenFileExistsAndIsImage(imagePath);

            while (validImageFile == false)
            {
                if (FileHandler.CheckIfGivenFileExistsAndIsImage(imagePath) == false)
                {
                    Console.WriteLine("Enter a valid file path to an image file");
                    imagePath = Console.ReadLine();
                    validImageFile = FileHandler.CheckIfGivenFileExistsAndIsImage(imagePath);
                }
            }

            originalImage = new Bitmap(imagePath);

            Bitmap greyScale = ImageEditingProgram.MakeImageGreyScale(originalImage);
            Bitmap negative = ImageEditingProgram.MakeImageNegative(originalImage);
            Bitmap blurred = ImageEditingProgram.MakeImageBlurred(originalImage);

            greyScale.Save(FileHandler.CreateCorrectFilenameForSaving(imagePath, "_greyScale"));
            negative.Save(FileHandler.CreateCorrectFilenameForSaving(imagePath, "_negative"));
            blurred.Save(FileHandler.CreateCorrectFilenameForSaving(imagePath, "_blurred"));

        }
    }
}
