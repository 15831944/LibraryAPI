using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Text;

namespace LibraryAPI
{
    public class SystemFileApp
    {
        /// <summary>
        /// Read the file data in encoding UTF8.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public string ReadFileDataUTF8(string filePath)
        {
            string allContent = "";
            
            string line;
            StreamReader file = new StreamReader(filePath, Encoding.UTF8);

            int index = 0;
            while ((line = file.ReadLine()) != null)
            {
                if (index == 0)
                {
                    allContent += line;
                }
                else
                {
                    allContent += "\n";
                    allContent += line;
                }
                index++;
            }
            file.Close();

            return allContent;
        }
        /// <summary>
        /// Gets the disk volume serial number.
        /// </summary>
        /// <returns></returns>
        public string GetDiskVolumeSerialNumber()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            disk.Get();
            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }
        /// <summary>
        /// Check if environment variable exists.
        /// </summary>
        /// <param name="var">The environment variable.</param>
        /// <param name="tgt">The EnvironmentVariableTarget.</param>
        /// <returns></returns>
        public bool EnvironmentVariableExist(string var, EnvironmentVariableTarget tgt)
        {
            string str;
            if (0 == tgt)
            {
                str = Environment.GetEnvironmentVariable(var);
            }
            else
            {
                str = Environment.GetEnvironmentVariable(var, tgt);
            }
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Check if the disk exists.
        /// </summary>
        /// <param name="folderPath">The folder path.</param>
        /// <returns></returns>
        public bool CheckDiskExist(string folderPath)
        {
            string diskPath = Directory.GetDirectoryRoot(folderPath);
            if (Directory.Exists(diskPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Gets the file version.
        /// </summary>
        /// <returns></returns>
        public string GetFileVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
    }
}
