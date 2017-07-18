using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibraryAPI
{
    public class Json
    {
        public string ReadJsonFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
