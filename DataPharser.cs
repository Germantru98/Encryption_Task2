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
    }
}