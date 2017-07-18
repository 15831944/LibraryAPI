using Ionic.Zip;
using System.IO;

namespace LibraryAPI
{
    public class ZipApp
    {
        /// <summary>
        /// Unzips the file with Ionic.Zip.dll function.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public void UnzipFile(string filePath)
        {
            using (ZipFile zip = ZipFile.Read(filePath))
            {
                zip.ExtractAll(Path.GetDirectoryName(filePath), ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}
