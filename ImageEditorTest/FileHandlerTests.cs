using NUnit.Framework;
using ImageEditor;
namespace Tests
{
    public class FileHandlerTests
    {

        [Test]
        public void CheckIfNonImageFileReturnsFalse()
        {
            string nonImagePath = @"C:\Users\Martin\Desktop\Fundamentals-of-Computer-Programming-with-CSharp-Nakov-eBook-v2013.pdf";
            Assert.AreEqual(false, FileHandler.CheckIfGivenFileExistsAndIsImage(nonImagePath));
        }

        [Test]
        public void CheckIfInvalidPathReturnsFalse()
        {
            string invalidPath = @"hej";
            Assert.AreEqual(false, FileHandler.CheckIfGivenFileExistsAndIsImage(invalidPath));
        }

        [Test]
        public void CheckIfFilePathIsCorrectIfFileIsInFolderWithSameName()
        {
            string testImagePath = @"‪C:\Users\Martin\Desktop\123\123.jpg";
            string testSuffix = "_test";
            string expectedPath = @"‪C:\Users\Martin\Desktop\123\123_test.jpg";
            Assert.AreEqual(expectedPath, FileHandler.CreateCorrectFilenameForSaving(testImagePath, testSuffix));
        }




    }
}