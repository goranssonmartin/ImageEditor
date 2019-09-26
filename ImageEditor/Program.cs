using System;
using System.Drawing;
using System.IO;

namespace ImageEditor
{
    public class ImageEditingProgram
    {
        public static Bitmap MakeImageGreyScale(Bitmap originalImage)
        {
            Bitmap greyScaleImage = new Bitmap(originalImage.Width, originalImage.Height);

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
            Bitmap blurredImage = new Bitmap(originalImage.Width, originalImage.Height);


            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    int averageR = 0;
                    int averageG = 0;
                    int averageB = 0;

                    //Top Left Corner
                    if (x == 0 && y == 0)
                    {
                        averageR = originalImage.GetPixel(x, y).R + originalImage.GetPixel(x + 1, y).R + originalImage.GetPixel(x, y + 1).R + originalImage.GetPixel(x + 1, y + 1).R;
                        averageG = originalImage.GetPixel(x, y).G + originalImage.GetPixel(x + 1, y).G + originalImage.GetPixel(x, y + 1).G + originalImage.GetPixel(x + 1, y + 1).G;
                        averageB = originalImage.GetPixel(x, y).B + originalImage.GetPixel(x + 1, y).B + originalImage.GetPixel(x, y + 1).B + originalImage.GetPixel(x + 1, y + 1).B;
                        averageR = averageR / 4;
                        averageG = averageG / 4;
                        averageB = averageB / 4;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                    }

                    //Bottom Left Corner
                    else if (x == 0 && y == originalImage.Height - 1)
                    {
                        averageR = originalImage.GetPixel(x, y).R + originalImage.GetPixel(x, y - 1).R + originalImage.GetPixel(x + 1, y - 1).R + originalImage.GetPixel(x + 1, y).R;
                        averageG = originalImage.GetPixel(x, y).G + originalImage.GetPixel(x, y - 1).G + originalImage.GetPixel(x + 1, y - 1).G + originalImage.GetPixel(x + 1, y).G;
                        averageB = originalImage.GetPixel(x, y).B + originalImage.GetPixel(x, y - 1).B + originalImage.GetPixel(x + 1, y - 1).B + originalImage.GetPixel(x + 1, y).B;
                        averageR = averageR / 4;
                        averageG = averageG / 4;
                        averageB = averageB / 4;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                    }

                    //Top Right Corner
                    else if (x == originalImage.Width - 1 && y == 0)
                    {
                        averageR = originalImage.GetPixel(x, y).R + originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x - 1, y + 1).R + originalImage.GetPixel(x, y + 1).R;
                        averageG = originalImage.GetPixel(x, y).G + originalImage.GetPixel(x - 1, y).G + originalImage.GetPixel(x - 1, y + 1).G + originalImage.GetPixel(x, y + 1).G;
                        averageB = originalImage.GetPixel(x, y).B + originalImage.GetPixel(x - 1, y).B + originalImage.GetPixel(x - 1, y + 1).B + originalImage.GetPixel(x, y + 1).B;
                        averageR = averageR / 4;
                        averageG = averageG / 4;
                        averageB = averageB / 4;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                    }

                    //Bottom Right Corner
                    else if (x == originalImage.Width - 1 && y == originalImage.Height - 1)
                    {
                        averageR = originalImage.GetPixel(x, y).R + originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x - 1, y - 1).R + originalImage.GetPixel(x, y - 1).R;
                        averageG = originalImage.GetPixel(x, y).G + originalImage.GetPixel(x - 1, y).G + originalImage.GetPixel(x - 1, y - 1).G + originalImage.GetPixel(x, y - 1).G;
                        averageB = originalImage.GetPixel(x, y).B + originalImage.GetPixel(x - 1, y).B + originalImage.GetPixel(x - 1, y - 1).B + originalImage.GetPixel(x, y - 1).B;
                        averageR = averageR / 4;
                        averageG = averageG / 4;
                        averageB = averageB / 4;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                    }

                    //Left Side
                    else if (x == 0 && y > 0 && y < originalImage.Height - 1)
                    {
                        averageR = originalImage.GetPixel(x, y - 1).R + originalImage.GetPixel(x + 1, y - 1).R + originalImage.GetPixel(x, y).R + originalImage.GetPixel(x + 1, y).R + originalImage.GetPixel(x, y + 1).R + originalImage.GetPixel(x + 1, y + 1).R;
                        averageG = originalImage.GetPixel(x, y - 1).G + originalImage.GetPixel(x + 1, y - 1).G + originalImage.GetPixel(x, y).G + originalImage.GetPixel(x + 1, y).G + originalImage.GetPixel(x, y + 1).G + originalImage.GetPixel(x + 1, y + 1).G;
                        averageB = originalImage.GetPixel(x, y - 1).B + originalImage.GetPixel(x + 1, y - 1).B + originalImage.GetPixel(x, y).B + originalImage.GetPixel(x + 1, y).B + originalImage.GetPixel(x, y + 1).B + originalImage.GetPixel(x + 1, y + 1).B;
                        averageR = averageR / 6;
                        averageG = averageG / 6;
                        averageB = averageB / 6;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                    }
                    //Top Side
                    else if (y == 0 && x > 0 && x < originalImage.Width - 1)
                    {
                        averageR = originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x, y).R + originalImage.GetPixel(x + 1, y).R + originalImage.GetPixel(x - 1, y + 1).R + originalImage.GetPixel(x, y + 1).R + originalImage.GetPixel(x + 1, y + 1).R;
                        averageG = originalImage.GetPixel(x - 1, y).G + originalImage.GetPixel(x, y).G + originalImage.GetPixel(x + 1, y).G + originalImage.GetPixel(x - 1, y + 1).G + originalImage.GetPixel(x, y + 1).G + originalImage.GetPixel(x + 1, y + 1).G;
                        averageB = originalImage.GetPixel(x - 1, y).B + originalImage.GetPixel(x, y).B + originalImage.GetPixel(x + 1, y).B + originalImage.GetPixel(x - 1, y + 1).B + originalImage.GetPixel(x, y + 1).B + originalImage.GetPixel(x + 1, y + 1).B;
                        averageR = averageR / 6;
                        averageG = averageG / 6;
                        averageB = averageB / 6;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                    }
                    //Right Side
                    else if (x == originalImage.Width - 1 && y > 0 && y < originalImage.Height - 1)
                    {
                        averageR = originalImage.GetPixel(x - 1, y - 1).R + originalImage.GetPixel(x, y - 1).R + originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x, y).R + originalImage.GetPixel(x - 1, y + 1).R + originalImage.GetPixel(x, y + 1).R;
                        averageG = originalImage.GetPixel(x - 1, y - 1).G + originalImage.GetPixel(x, y - 1).G + originalImage.GetPixel(x - 1, y).G + originalImage.GetPixel(x, y).G + originalImage.GetPixel(x - 1, y + 1).G + originalImage.GetPixel(x, y + 1).G;
                        averageB = originalImage.GetPixel(x - 1, y - 1).B + originalImage.GetPixel(x, y - 1).B + originalImage.GetPixel(x - 1, y).B + originalImage.GetPixel(x, y).B + originalImage.GetPixel(x - 1, y + 1).B + originalImage.GetPixel(x, y + 1).B;
                        averageR = averageR / 6;
                        averageG = averageG / 6;
                        averageB = averageB / 6;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));

                    }
                    //Bottom Side
                    else if (y == originalImage.Height - 1 && x > 0 && x < originalImage.Width - 1)
                    {
                        averageR = originalImage.GetPixel(x - 1, y - 1).R + originalImage.GetPixel(x, y - 1).R + originalImage.GetPixel(x + 1, y - 1).R + originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x, y).R + originalImage.GetPixel(x + 1, y).R;
                        averageG = originalImage.GetPixel(x - 1, y - 1).G + originalImage.GetPixel(x, y - 1).G + originalImage.GetPixel(x + 1, y - 1).G + originalImage.GetPixel(x - 1, y).G + originalImage.GetPixel(x, y).G + originalImage.GetPixel(x + 1, y).G;
                        averageB = originalImage.GetPixel(x - 1, y - 1).B + originalImage.GetPixel(x, y - 1).B + originalImage.GetPixel(x + 1, y - 1).B + originalImage.GetPixel(x - 1, y).B + originalImage.GetPixel(x, y).B + originalImage.GetPixel(x + 1, y).B;
                        averageR = averageR / 6;
                        averageG = averageG / 6;
                        averageB = averageB / 6;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));

                    }
                    //Middle
                    else if (x >= 1 && y >= 1 && x < originalImage.Width - 1 && y < originalImage.Height - 1)
                    {
                        averageR = originalImage.GetPixel(x - 1, y - 1).R + originalImage.GetPixel(x, y - 1).R + originalImage.GetPixel(x + 1, y - 1).R + originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x, y).R + originalImage.GetPixel(x + 1, y).R + originalImage.GetPixel(x - 1, y + 1).R + originalImage.GetPixel(x, y + 1).R + originalImage.GetPixel(x + 1, y + 1).R;
                        averageG = originalImage.GetPixel(x - 1, y - 1).G + originalImage.GetPixel(x, y - 1).G + originalImage.GetPixel(x + 1, y - 1).G + originalImage.GetPixel(x - 1, y).G + originalImage.GetPixel(x, y).G + originalImage.GetPixel(x + 1, y).G + originalImage.GetPixel(x - 1, y + 1).G + originalImage.GetPixel(x, y + 1).G + originalImage.GetPixel(x + 1, y + 1).G;
                        averageB = originalImage.GetPixel(x - 1, y - 1).B + originalImage.GetPixel(x, y - 1).B + originalImage.GetPixel(x + 1, y - 1).B + originalImage.GetPixel(x - 1, y).B + originalImage.GetPixel(x, y).B + originalImage.GetPixel(x + 1, y).B + originalImage.GetPixel(x - 1, y + 1).B + originalImage.GetPixel(x, y + 1).B + originalImage.GetPixel(x + 1, y + 1).B;
                        averageR = averageR / 9;
                        averageG = averageG / 9;
                        averageB = averageB / 9;
                        blurredImage.SetPixel(x, y, Color.FromArgb(255, averageR, averageG, averageB));
                    }
                }

            }
            return blurredImage;
        }
    }
}
