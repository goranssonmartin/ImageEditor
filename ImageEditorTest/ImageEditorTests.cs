using NUnit.Framework;
using ImageEditor;
using System.Drawing;

namespace Tests
{
    public class ImageEditorTests
    {

        [Test]
        public void Test_IfNegativeImageReallyIsNegative()
        {
            Bitmap negativeTest = new Bitmap(3, 3);
            Color black = Color.FromArgb(255, 0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255, 255);

            negativeTest.SetPixel(0, 0, black);
            negativeTest.SetPixel(0, 1, black);
            negativeTest.SetPixel(0, 2, black);
            negativeTest.SetPixel(1, 0, black);
            negativeTest.SetPixel(1, 1, black);
            negativeTest.SetPixel(1, 2, black);
            negativeTest.SetPixel(2, 0, black);
            negativeTest.SetPixel(2, 1, black);
            negativeTest.SetPixel(2, 2, black);
            Bitmap bitmapTestResult = ImageEditingProgram.MakeImageNegative(negativeTest);
            Assert.AreEqual(white, bitmapTestResult.GetPixel(0, 0));
            Assert.AreEqual(white, bitmapTestResult.GetPixel(1, 1));
            Assert.AreEqual(white, bitmapTestResult.GetPixel(2, 2));
        }

        [Test]
        public void Test_IfNegativeImageReturnsSameSize()
        {
            Bitmap negativeTest = new Bitmap(3, 3);
            Assert.AreEqual(negativeTest.Size, ImageEditingProgram.MakeImageNegative(negativeTest).Size);

        }

        [Test]
        public void Test_IfGreyScaleImageReallyIsGreyScale()
        {
            Bitmap greyScaleTest = new Bitmap(3, 3);
            Color testPixel = Color.FromArgb(255, 100, 100, 80);
            Color expectedPixel = Color.FromArgb(255, 93, 93, 93);

            greyScaleTest.SetPixel(0, 1, testPixel);
            greyScaleTest.SetPixel(0, 2, testPixel);
            greyScaleTest.SetPixel(1, 0, testPixel);
            greyScaleTest.SetPixel(0, 0, testPixel);
            greyScaleTest.SetPixel(1, 1, testPixel);
            greyScaleTest.SetPixel(1, 2, testPixel);
            greyScaleTest.SetPixel(2, 0, testPixel);
            greyScaleTest.SetPixel(2, 1, testPixel);
            greyScaleTest.SetPixel(2, 2, testPixel);
            Assert.AreEqual(expectedPixel, ImageEditingProgram.MakeImageGreyScale(greyScaleTest).GetPixel(1, 1));
        }

        [Test]
        public void Test_IfGreyScaleImageReturnsSameSize()
        {
            Bitmap greyScaleTest = new Bitmap(3, 3);
            Assert.AreEqual(greyScaleTest.Size, ImageEditingProgram.MakeImageGreyScale(greyScaleTest).Size);
        }


        [Test]
        public void Test_CheckIfMiddlePixelsGetsExpectedBlur()
        {
            Bitmap blurredTest = new Bitmap(3, 3);
            Color black = Color.FromArgb(255, 0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255, 255);
            Color expectedBlurredPixel = Color.FromArgb(255, 28, 28, 28);

            //3x3 with middle pixel white surrounded by black pixels
            blurredTest.SetPixel(0, 0, black);
            blurredTest.SetPixel(0, 1, black);
            blurredTest.SetPixel(0, 2, black);
            blurredTest.SetPixel(1, 0, black);
            blurredTest.SetPixel(1, 1, white);
            blurredTest.SetPixel(1, 2, black);
            blurredTest.SetPixel(2, 0, black);
            blurredTest.SetPixel(2, 1, black);
            blurredTest.SetPixel(2, 2, black);
            Assert.AreEqual(expectedBlurredPixel, ImageEditingProgram.MakeImageBlurred(blurredTest).GetPixel(1, 1));
        }

        [Test]
        public void Test_CheckIfCornerPixelsGetsExpectedBlur()
        {
            Bitmap blurredTest = new Bitmap(3, 3);
            Color black = Color.FromArgb(255, 0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255, 255);
            Color expectedBlurredPixel = Color.FromArgb(255, 63, 63, 63);

            //3x3 with middle pixel white surrounded by black pixels
            blurredTest.SetPixel(0, 0, black);
            blurredTest.SetPixel(0, 1, black);
            blurredTest.SetPixel(0, 2, black);
            blurredTest.SetPixel(1, 0, black);
            blurredTest.SetPixel(1, 1, white);
            blurredTest.SetPixel(1, 2, black);
            blurredTest.SetPixel(2, 0, black);
            blurredTest.SetPixel(2, 1, black);
            blurredTest.SetPixel(2, 2, black);
            Bitmap testResultBitmap = ImageEditingProgram.MakeImageBlurred(blurredTest);
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(0, 0));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(2, 0));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(0, 2));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(2, 2));
        }

        
        [Test]
        public void Test_CheckIfSidePixelsGetsExpectedBlur()
        {
            Bitmap blurredTest = new Bitmap(3, 3);
            Color black = Color.FromArgb(255, 0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255, 255);
            Color expectedBlurredPixel = Color.FromArgb(255, 42, 42, 42);

            //3x3 with middle pixel white surrounded by black pixels
            blurredTest.SetPixel(0, 0, black);
            blurredTest.SetPixel(0, 1, black);
            blurredTest.SetPixel(0, 2, black);
            blurredTest.SetPixel(1, 0, black);
            blurredTest.SetPixel(1, 1, white);
            blurredTest.SetPixel(1, 2, black);
            blurredTest.SetPixel(2, 0, black);
            blurredTest.SetPixel(2, 1, black);
            blurredTest.SetPixel(2, 2, black);
            Bitmap testResultBitmap = ImageEditingProgram.MakeImageBlurred(blurredTest);
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(0, 1));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(1, 0));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(2, 1));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(1, 2));
        }

        [Test]
        public void Test_CheckIfBlurredImageReturnsSameSize()
        {
            Bitmap testBlurImageSize = new Bitmap(3, 3);
            Assert.AreEqual(testBlurImageSize.Size, ImageEditingProgram.MakeImageBlurred(testBlurImageSize).Size);
        }

        [Test]
        public void Test_CheckIfSmallImageGetsCorrectBlur()
        {
            Bitmap blurredTest = new Bitmap(2, 2);
            Color black = Color.FromArgb(255, 0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255, 255);
            Color expectedBlurredPixel = Color.FromArgb(255, 127, 127, 127);

            //2x2 with middle pixel white surrounded by black pixels
            blurredTest.SetPixel(0, 0, white);
            blurredTest.SetPixel(0, 1, black);
            blurredTest.SetPixel(1, 0, black);
            blurredTest.SetPixel(1, 1, white);
            Bitmap testResultBitmap = ImageEditingProgram.MakeImageBlurred(blurredTest);
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(0, 0));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(0, 1));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(1, 0));
            Assert.AreEqual(expectedBlurredPixel, testResultBitmap.GetPixel(1, 1));
        }


    }
}