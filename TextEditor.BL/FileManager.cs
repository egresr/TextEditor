using System.IO;
using System.Text;

namespace TextEditor.BL
{
    public class FileManager
    {
        private readonly Encoding _deafaultEncoding = Encoding.GetEncoding(1251);

        //Proverka na suschestvovanie feila po ukazannomu puti
        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        // Chtenie feila po ukazannomu puti s ukazaniem i bez ukazanija kodirovki
        // Peregruska metoda
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _deafaultEncoding);
        }
        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }

        // Zapis v feil po ukazannomu puti s ukazaniem i bez ukazanija kodirovki
        // Peregruska metoda
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _deafaultEncoding);
        }
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }

        //public int GetSymbolCount(string filePath, Encoding encoding)
        //{
        //    return GetContent(filePath).Length;
        //}

        public int GetSymbolCount(string content)
        {
            return content.Length;
        }
    }
}
