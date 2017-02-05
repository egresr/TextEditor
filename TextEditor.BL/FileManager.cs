using System.IO;
using System.Text;

namespace TextEditor.BL
{

    //S pomoschju Interface dostigaetsja abstrakzija.
    //Tak Vysyvajuschij fail obraschaetsja naprimer k GetContent i
    //poluchaet nazad text iz faila, no pri neobhodimosti mozhno pomenjat
    //naprimer istochnik kontenta vmesto faila iz DB. Dlja vysyvajuschego
    //faila eto proidet ne zamecheno. tak kak mezhdu vyzyvajuschim failom
    //i ispolnjajuschim failom stoit interface, vse metody kotorogo objaza-
    //telno dolzhny byt ralizovanny v nasleduemom klasse.



    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string FilePath);
        void SaveContent(string conten, string FilePath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filePath);
    }
    public class FileManager : IFileManager
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
