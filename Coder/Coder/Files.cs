using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
    internal class Files
    {
        public static string ReadText(string FilePath)
        {
            string str;
            using (StreamReader reader = new StreamReader(FilePath))
            {
                str = reader.ReadToEnd();
            }
            return str;
        }
        public static string[] ReadLines(string FilePath)
        {
            string[] strings;
            using (StreamReader reader = new StreamReader(FilePath))
            {
                strings = File.ReadAllLines(FilePath);
            }
            return strings;
        }
        public static void WriteAllText(string FilePath, string Text)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.Write(Text);
            }
        }
        public static void WriteAllLines(string FilePath, string[] Texts)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (string item in Texts)
                {
                    writer.WriteLine(item);
                }
            }
        }
        public static bool FileExist(string FilePath)
        {
            return File.Exists(FilePath);
        }
        public static string[] GetFolderFiles(string FolderPath)
        {
            return Directory.GetFiles(FolderPath);
        }
        public static string[] GetFolderFiles(string FolderPath, string searchPatern)
        {
            return Directory.GetFiles(FolderPath, searchPatern);
        }
        public static bool DirectoryExist(string DirectoryPath)
        {
            return Directory.Exists(DirectoryPath);
        }
    }
}
