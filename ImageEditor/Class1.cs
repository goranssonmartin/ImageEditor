using System;
using System.Drawing;
using System.IO;

namespace ImageEditor
{
    public class ImageEditingProgram
    {
        public static Bitmap MakeImageGreyScale(Bitmap originalImage)
        {
            //Bitmap originalImage = new Bitmap(imageFilePath);
            Bitmap greyScaleImage = new Bitmap(originalImage.Width, originalImage.Height);
            //pixel value = medelvärde alla pixlar

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixels = originalImage.GetPixel(x, y);
                    int newPixelValue = (pixels.R + pixels.G + pixels.B) / 3;
                    greyScaleImage.SetPixel(x, y, Color.FromArgb(255, newPixelValue, newPixelValue, newPixelValue));
                }

            }

            return greyScaleImage;
        }

        public static Bitmap MakeImageNegative(Bitmap originalImage)
        {

            //pixel value = 255-current pixelvalue
            //Bitmap originalImage = new Bitmap(imageFilePath);
            Bitmap negativeImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixels = originalImage.GetPixel(x, y);
                    int newRValue = 255 - pixels.R;
                    int newGValue = 255 - pixels.G;
                    int newBValue = 255 - pixels.B;
                    negativeImage.SetPixel(x, y, Color.FromArgb(255, newRValue, newGValue, newBValue));

                }

            }

            return negativeImage;
        }

        public static Bitmap MakeImageBlurred(Bitmap originalImage)
        {
            Bitmap blurred = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 1; x < originalImage.Width-1; x++)
            {
                for (int y = 1; y < originalImage.Height-1; y++)
                {

                    int averageR = 0;
                    int averageG = 0;
                    int averageB = 0;
                    if (x >= 1 && y >= 1 && x < originalImage.Width && y < originalImage.Height)
                    {
                        averageR = originalImage.GetPixel(x - 1, y - 1).R + originalImage.GetPixel(x, y - 1).R + originalImage.GetPixel(x + 1, y - 1).R + originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x, y).R + originalImage.GetPixel(x + 1, y).R + originalImage.GetPixel(x - 1, y + 1).R + originalImage.GetPixel(x, y + 1).R + originalImage.GetPixel(x + 1, y + 1).R;
                        averageG = originalImage.GetPixel(x - 1, y - 1).G + originalImage.GetPixel(x, y - 1).G + originalImage.GetPixel(x + 1, y - 1).G + originalImage.GetPixel(x - 1, y).G + originalImage.GetPixel(x, y).G + originalImage.GetPixel(x + 1, y).G + originalImage.GetPixel(x - 1, y + 1).G + originalImage.GetPixel(x, y + 1).G + originalImage.GetPixel(x + 1, y + 1).G;
                        averageB = originalImage.GetPixel(x - 1, y - 1).B + originalImage.GetPixel(x, y - 1).B + originalImage.GetPixel(x + 1, y - 1).B + originalImage.GetPixel(x - 1, y).B + originalImage.GetPixel(x, y).B + originalImage.GetPixel(x + 1, y).B + originalImage.GetPixel(x - 1, y + 1).B + originalImage.GetPixel(x, y + 1).B + originalImage.GetPixel(x + 1, y + 1).B;
                        averageR = averageR / 9;
                        averageG = averageG / 9;
                        averageB = averageB / 9;
                    }

                    else if (x == 0 && y == 0) {

                    }

                    //else if
                    blurred.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                }

            }

            return blurred;
        }
    }
}
