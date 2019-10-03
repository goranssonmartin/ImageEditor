using System.Drawing;
using System.IO;

namespace ImageEditor
{
    public class FileHandler
    {
        public static string CreateCorrectFilenameForSaving(string imagePath, string wantedSuffix)
        {
            string imageDirectory = Path.GetDirectoryName(imagePath);
            string imageFileNameWithoutExtension = Path.GetFileNameWithoutExtension(imagePath);
            string imageExtension = Path.GetExtension(imagePath);
            string newFileName = imageFileNameWithoutExtension + wantedSuffix + imageExtension;
            string fullNewFileName = Path.Combine(imageDirectory, newFileName);
            return fullNewFileName;
        }

        public static bool CheckIfGivenFileExistsAndIsImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                try
                {
                    Bitmap test = new Bitmap(imagePath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }
    }
}

