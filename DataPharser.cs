using System.IO;
using System.Text;

namespace Encryption_Task2
{
    internal class DataPharser
    {
        public string getMessage(string filePath)
        {
            using (StreamReader stream = new StreamReader(filePath, Encoding.Default))
            {
                return stream.ReadToEnd();
            }
        }

        public char[] GetAlphabet()
        {
            using (StreamReader stream = new StreamReader("Alphabet.txt", Encoding.Default))
            {
                char[] alphabet = stream.ReadToEnd().ToCharArray();
                return alphabet;
            }
        }
    }
}