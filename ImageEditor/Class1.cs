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
            Bitmap greyScaleImage = new Bitmap(originalImage.Width,originalImage.Height);
            //pixel value = medelvärde alla pixlar

            for (int x = 0; x < originalImage.Width; x++) {
                for (int y = 0; y < originalImage.Height    ; y++)
                {
                    Color pixels = originalImage.GetPixel(x,y);
                    int newPixelValue = (pixels.R + pixels.G + pixels.B) / 3;
                    greyScaleImage.SetPixel(x,y,Color.FromArgb(255,newPixelValue,newPixelValue,newPixelValue));
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
                    int newRValue = 255-pixels.R;
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

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    

                }

            }

            return blurred;
        }
    }
}
