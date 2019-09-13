using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task2
{
    class DataPharser
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
